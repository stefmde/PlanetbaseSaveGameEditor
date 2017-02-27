using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "construction")]
	public class ConstructionCore
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "enabled")]
		public BoolValueAttribute Enabled { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Double> State { get; set; }

		[XmlElement(ElementName = "build-progress")]
		public ValueAttribute<Double> BuildProgress { get; set; }

		[XmlElement(ElementName = "condition")]
		public ValueAttribute<Double> Condition { get; set; }

		[XmlElement(ElementName = "oxygen")]
		public ValueAttribute<Double> Oxygen { get; set; }

		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "position")]
		public CoordinatesCore Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public CoordinatesCore Orientation { get; set; }

		[XmlElement(ElementName = "time-built")]
		public ValueAttribute<Double> TimeBuilt { get; set; }

		[XmlElement(ElementName = "locked")]
		public BoolValueAttribute Locked { get; set; }

		[XmlElement(ElementName = "high-priority")]
		public BoolValueAttribute HighPriority { get; set; }

		[XmlElement(ElementName = "module-type")]
		public ValueAttribute<ModuleType> ModuleType { get; set; }

		[XmlElement(ElementName = "size-index")]
		public ValueAttribute<Int32> SizeIndex { get; set; }

		[XmlElement(ElementName = "mobile-rotation")]
		public CoordinatesCore MobileRotation { get; set; }

		[XmlElement(ElementName = "components")]
		public ComponentsCore Components { get; set; }

		[XmlElement(ElementName = "power-storage")]
		public ValueAttribute<Double> PowerStorage { get; set; }

		[XmlElement(ElementName = "production-progress")]
		public ValueAttribute<Double> ProductionProgress { get; set; }

		[XmlElement(ElementName = "water-storage")]
		public ValueAttribute<Double> WaterStorage { get; set; }

		[XmlElement(ElementName = "resource-storage")]
		public ResourceStorageCore ResourceStorage { get; set; }

		[XmlElement(ElementName = "laser-charge")]
		public ValueAttribute<Double> Lasercharge { get; set; }

		[XmlElement(ElementName = "links")]
		public LinksCore Links { get; set; }

		[XmlElement(ElementName = "construction-materials")]
		public ConstructionMaterialsCore ConstructionMaterials { get; set; }

		[XmlElement(ElementName = "pending-construction-costs")]
		public PendingConstructionCostsCore PendingConstructionCosts { get; set; }
	}
}
