//  ReflectionIndexer.cs
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
using System.Collections;
using System.Text;
using System.Xml;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace MonoDevelop.Projects.Parser
{
	[Serializable]
	internal class ReflectionIndexer : DefaultIndexer
	{
/*		string GetIndexerName(PropertyInfo propertyInfo)
		{
			StringBuilder propertyName = new StringBuilder("Item(");
			ParameterInfo[] p = propertyInfo.GetIndexParameters();
			for (int i = 0; i < p.Length; ++i) {
				propertyName.Append(p[i].ParameterType.FullName);
				if (i + 1 < p.Length) {
					propertyName.Append(',');
				}
			}
			propertyName.Append(')');
			return propertyName.ToString();
		}
*/
		public ReflectionIndexer (PropertyDefinition propertyInfo, XmlDocument docs)
		{
			int line = 0, col = 0;
			string file = null;
			
			// indexers does have the same name as the object that declare the indexers
			Name = propertyInfo.DeclaringType.Name;
			
			// show the abstract layer that we have getter & setters
			if (propertyInfo.GetMethod != null) {
				if (propertyInfo.GetMethod.HasBody && propertyInfo.GetMethod.Body.Instructions.Count > 0) {
					SequencePoint sp = propertyInfo.GetMethod.Body.Instructions[0].SequencePoint;
					if (sp != null) {
						getterRegion = new DefaultRegion (sp.StartLine, sp.StartColumn);
						file = sp.Document.Url;
						line = sp.StartLine;
						col = sp.StartColumn;
					}
				}
				if (getterRegion == null)
					getterRegion = new DefaultRegion(0, 0, 0, 0);
			} else {
				getterRegion = null;
			}
			
			if (propertyInfo.SetMethod != null) {
				if (propertyInfo.SetMethod.HasBody && propertyInfo.SetMethod.Body.Instructions.Count > 0) {
					SequencePoint sp = propertyInfo.SetMethod.Body.Instructions[0].SequencePoint;
					if (sp != null) {
						setterRegion = new DefaultRegion (sp.StartLine, sp.StartColumn);
						file = sp.Document.Url;
						if (line == 0 || sp.StartLine < line) {
							line = sp.StartLine;
							col = sp.StartColumn;
						}
					}
				}
				if (setterRegion == null)
					setterRegion = new DefaultRegion(0, 0, 0, 0);
			} else {
				setterRegion = null;
			}
			
			if (file != null) {
				Region = new DefaultRegion (line, col);
				Region.FileName = file;
			}

			XmlNode node = null;
			if (docs != null) {
				node = docs.SelectSingleNode ("/Type/Members/Member[@MemberName='" + propertyInfo.Name + "']");
				if (node != null) {
					XmlNode docNode = node.SelectSingleNode ("Docs/summary");
					if (docNode != null) {
						Documentation = node.InnerXml;
					}
				}
			}
			
			returnType = new ReflectionReturnType(propertyInfo.PropertyType);
			
			MethodDefinition methodBase = null;
			try {
				methodBase = propertyInfo.GetMethod;
			} catch (Exception) {}
			
			if (methodBase == null) {
				try {
					methodBase = propertyInfo.SetMethod;
				} catch (Exception) {}
			}
			
			if (methodBase != null) {
				modifiers |= ReflectionMethod.GetModifiers (methodBase.Attributes);
			} else { // assume public property, if no methodBase could be get.
				modifiers = ModifierEnum.Public;
			}
			
			ParameterDefinitionCollection p = propertyInfo.Parameters;
			foreach (ParameterDefinition parameterInfo in p) {
				parameters.Add(new ReflectionParameter(parameterInfo, node));
			}
		}
	}
}
