﻿using System.Collections.Generic;
using System.Linq;
using System;

namespace MagicdrawMigrator
{
	/// <summary>
	/// Description of MDDiagram.
	/// </summary>
	public class MDDiagram
	{
		public MDDiagram()
		{
			_diagramObjects = new List<MDDiagramObject>();
		}
		List<MDDiagramObject> _diagramObjects;
		public List<MDDiagramObject> diagramObjects 
		{
			get 
			{
				return _diagramObjects;
			}
			set 
			{
				_diagramObjects = value;
			}
		}
		public void addDiagramObject(MDDiagramObject diagramObject)
		{
			this.diagramObjects.Add(diagramObject);
		}
		
	}
}
