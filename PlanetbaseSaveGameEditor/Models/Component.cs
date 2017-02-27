using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Component
	{
		public string Type { get; set; }


		public List<bool> Enabled { get; set; }

		public int State { get; set; }

		public double BuildProgress { get; set; }

		public int Id { get; set; }

		public ComponentTypeType ComponentType { get; set; }

		public Coordinates Position { get; set; }

		public Coordinates Orientation { get; set; }

		public double Condition { get; set; }

		public double ProductionProgress { get; set; }

		public double Time { get; set; }

		public int ProducedItemIndex { get; set; }

		public ResourceContainer ResourceContainer { get; set; }

		public PendingConstructionCosts PendingConstructionCosts { get; set; }

		public ConstructionMaterials ConstructionMaterials { get; set; }

		public int SizeIndex { get; set; }

		public ModuleType ModuleType { get; set; }
	}

}