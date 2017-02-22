using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "component")]
	public class Component
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "enabled")]
		public List<BoolValueAttribute> Enabled { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Int32> State { get; set; }

		[XmlElement(ElementName = "build-progress")]
		public ValueAttribute<Double> BuildProgress { get; set; }

		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "component-type")]
		public ValueAttribute<ComponentTypeType> ComponentType { get; set; }

		[XmlElement(ElementName = "position")]
		public Coordinates Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Coordinates Orientation { get; set; }

		[XmlElement(ElementName = "condition")]
		public ValueAttribute<Double> Condition { get; set; }

		[XmlElement(ElementName = "production-progress")]
		public ValueAttribute<Double> ProductionProgress { get; set; }

		[XmlElement(ElementName = "time")]
		public ValueAttribute<Double> Time { get; set; }

		[XmlElement(ElementName = "produced-item-index")]
		public ValueAttribute<Int32> ProducedItemIndex { get; set; }

		[XmlElement(ElementName = "resource-container")]
		public ResourceContainer ResourceContainer { get; set; }

		[XmlElement(ElementName = "pending-construction-costs")]
		public PendingConstructionCosts PendingConstructionCosts { get; set; }

		[XmlElement(ElementName = "construction-materials")]
		public ConstructionMaterials ConstructionMaterials { get; set; }

		[XmlElement(ElementName = "size-index")]
		public ValueAttribute<Int32> SizeIndex { get; set; }

		[XmlElement(ElementName = "module-type")]
		public ValueAttribute<ModuleType> ModuleType { get; set; }
	}

}