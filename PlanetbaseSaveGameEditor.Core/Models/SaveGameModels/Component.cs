using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "component")]
	public class Component
	{
		[XmlElement(ElementName = "enabled")]
		public List<Enabled> Enabled { get; set; }

		[XmlElement(ElementName = "state")]
		public State State { get; set; }

		[XmlElement(ElementName = "build-progress")]
		public BuildProgress BuildProgress { get; set; }

		[XmlElement(ElementName = "id")]
		public Id Id { get; set; }

		[XmlElement(ElementName = "component-type")]
		public ComponentType ComponentType { get; set; }

		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }

		[XmlElement(ElementName = "condition")]
		public Condition Condition { get; set; }

		[XmlElement(ElementName = "production-progress")]
		public ProductionProgress ProductionProgress { get; set; }

		[XmlElement(ElementName = "time")]
		public Time Time { get; set; }

		[XmlElement(ElementName = "produced-item-index")]
		public ProducedItemIndex ProducedItemIndex { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlElement(ElementName = "resource-container")]
		public ResourceContainer ResourceContainer { get; set; }

		[XmlElement(ElementName = "pending-construction-costs")]
		public PendingConstructionCosts PendingConstructionCosts { get; set; }

		[XmlElement(ElementName = "construction-materials")]
		public ConstructionMaterials ConstructionMaterials { get; set; }
	}

}