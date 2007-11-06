//  WorkbenchMemento.cs
//
//  This file was derived from a file from #Develop. 
//
//  Copyright (C) 2001-2007 Mike Krüger <mkrueger@novell.com>
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Drawing;
using System.Xml;

using MonoDevelop.Core;

namespace MonoDevelop.Ide.Gui
{
	/// <summary>
	/// This class contains the state of the <code>MdiWorkspace</code>, it is used to 
	/// make the <code>MdiWorkspace</code> state persistent.
	/// </summary>
	public class WorkbenchMemento 
	{
		Properties properties = new Properties ();

		public Properties ToProperties ()
		{
			return properties;
		}
		
		public Gdk.WindowState WindowState {
			get {
				return properties.Get ("windowState", (Gdk.WindowState)0);
			}
			set {
				 properties.Set ("windowState", value);
			}
		}
		
		public Rectangle Bounds {
			get {
				return properties.Get ("bounds", new Rectangle(0, 0, 640, 480));
			}
			set {
				properties.Set ("bounds", value);
			}
		}
		
		public bool FullScreen {
			get {
				return properties.Get ("fullscreen", false);
			}
			set {
				properties.Set ("fullscreen", value);
			}
		}
		
		public Properties LayoutMemento {
			get {
				return properties.Get ("layoutMemento", new Properties ());
			}
			set {
				properties.Set ("layoutMemento", value);
			}
		}
		
		/// <summary>
		/// Creates a new instance of the <code>MdiWorkspaceMemento</code>.
		/// </summary>
		public WorkbenchMemento (Properties properties)
		{
			this.properties = properties;
		}
	}
}
