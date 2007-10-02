// WebDeployService.cs
// 
// Author:
//   Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Threading;
using System.Collections.Generic;
using Gtk;

using MonoDevelop.Core;
using MonoDevelop.Core.Gui.ProgressMonitoring;
using MonoDevelop.Deployment;
using MonoDevelop.Deployment.Gui;
using AspNetAddIn;

namespace MonoDevelop.AspNet.Deployment
{
	
	public class WebDeployService
	{
		private WebDeployService ()
		{
		}
		
		static public void Deploy (AspNetAppProject project, WebDeployTarget target)
		{
			Deploy (project, new WebDeployTarget[] { target });
		}
		
		static public void Deploy (AspNetAppProject project, ICollection<WebDeployTarget> targets)
		{
			//project needs to be built before it can be deployed
			MonoDevelop.Ide.Gui.IdeApp.ProjectOperations.Build (project);
			
			//set up and launch a copying thread
			DeployThreadParams threadParams = new DeployThreadParams (); 
			threadParams.Files = project.GetDeployFiles ();
			Dictionary<string, string> taskAliases = new Dictionary<string,string> ();
			foreach (WebDeployTarget target in targets) {
				threadParams.Targets.Add ((WebDeployTarget) target.Clone ());
				taskAliases.Add (target.LocationName, target.GetMarkup ());
			}
			
			MultiTaskDialogProgressMonitor monitor = new MultiTaskDialogProgressMonitor (true, true, true, taskAliases);
			monitor.SetDialogTitle (MonoDevelop.Core.GettextCatalog.GetString ("Web Deployment Progress"));
			monitor.SetOperationTitle (MonoDevelop.Core.GettextCatalog.GetString ("Deploying {0}...", project.Name));
			threadParams.Monitor = monitor;
			
			Thread deployThread = new Thread (new ParameterizedThreadStart (DoDeploy));
			deployThread.Start (threadParams);
		}
		
		
		static void DoDeploy (object o)
		{
			DeployThreadParams threadParams = (DeployThreadParams) o;
			try {
				IFileReplacePolicy replacePolicy = new DialogFileReplacePolicy ();
				
				foreach (WebDeployTarget target in threadParams.Targets) {
					if (threadParams.Monitor.IsCancelRequested)
						break;
					try {
						DeployContext context = new DeployContext (new WebDeployResolver (), null, null);
						target.FileCopier.CopyFiles (threadParams.Monitor, replacePolicy, threadParams.Files, context);
					} catch (OperationCanceledException ex) {
						threadParams.Monitor.ReportError (GettextCatalog.GetString ("Web deploy aborted."), ex);
						break;
					} catch (InvalidOperationException ex) {
						threadParams.Monitor.ReportError (GettextCatalog.GetString ("Web deploy aborted."), ex);
						break;
					}
				}
			} catch (Exception e) {
				MonoDevelop.Core.Runtime.LoggingService.Error ((object)"Unhandled exception in the web deploy thread", e);
				MonoDevelop.Core.Gui.Services.MessageService.ShowError (e, "Unhandled exception in the web deploy thread");
			} finally {
				threadParams.Monitor.Dispose ();
			}
		}
		
		static public void DeployDialog (AspNetAppProject project)
		{
			WebDeployLaunchDialog dialog = new WebDeployLaunchDialog (project);
			Gtk.Window rootWindow = MonoDevelop.Ide.Gui.IdeApp.Services.MessageService.RootWindow as Gtk.Window;
			dialog.TransientFor = rootWindow;
			dialog.Modal = true;
			dialog.Show ();
			
			ICollection<WebDeployTarget> targets = null;
			
			ResponseType response = (ResponseType) dialog.Run ();
			if (response == Gtk.ResponseType.Ok)
				targets = dialog.GetSelectedTargets ();
			dialog.Destroy ();
			
			if (targets != null && targets.Count > 0)
				Deploy (project, targets);
		}
		
		class DeployThreadParams
		{
			public List<WebDeployTarget> Targets = new List<WebDeployTarget> ();
			public DeployFileCollection Files;
			public IProgressMonitor Monitor;
		}
	}
}
