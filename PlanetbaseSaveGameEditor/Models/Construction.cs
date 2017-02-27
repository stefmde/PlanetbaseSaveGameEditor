using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Construction
	{
		public string Type { get; set; }

		public bool Enabled { get; set; }

		public double State { get; set; }

		public double BuildProgress { get; set; }

		public double Condition { get; set; }

		public double Oxygen { get; set; }

		public int Id { get; set; }

		public Coordinates Position { get; set; }

		public Coordinates Orientation { get; set; }

		public double TimeBuilt { get; set; }

		public bool Locked { get; set; }

		public bool HighPriority { get; set; }

		public ModuleType ModuleType { get; set; }

		public int SizeIndex { get; set; }

		public Coordinates MobileRotation { get; set; }

		public Components Components { get; set; }

		public double PowerStorage { get; set; }

		public double ProductionProgress { get; set; }

		public double WaterStorage { get; set; }

		public List<Slot> ResourceStorageSlots { get; set; }

		public double Lasercharge { get; set; }

		public List<int> LinkIds { get; set; }

		// TODO: Check this
		public List<int> ConstructionMaterialIds { get; set; }

		public PendingConstructionCosts PendingConstructionCosts { get; set; }
	}
}
