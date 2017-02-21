using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "construction")]
	public class Construction
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "enabled")]
		public Enabled Enabled { get; set; }

		[XmlElement(ElementName = "state")]
		public State State { get; set; }

		[XmlElement(ElementName = "build-progress")]
		public BuildProgress BuildProgress { get; set; }

		[XmlElement(ElementName = "condition")]
		public Condition Condition { get; set; }

		[XmlElement(ElementName = "oxygen")]
		public Oxygen Oxygen { get; set; }

		[XmlElement(ElementName = "id")]
		public Id Id { get; set; }

		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }

		[XmlElement(ElementName = "time-built")]
		public TimeBuilt TimeBuilt { get; set; }

		[XmlElement(ElementName = "locked")]
		public Locked Locked { get; set; }

		[XmlElement(ElementName = "high-priority")]
		public HighPriority HighPriority { get; set; }

		[XmlElement(ElementName = "module-type")]
		public ModuleType ModuleType { get; set; }

		[XmlElement(ElementName = "size-index")]
		public SizeIndex SizeIndex { get; set; }

		[XmlElement(ElementName = "mobile-rotation")]
		public MobileRotation MobileRotation { get; set; }

		[XmlElement(ElementName = "components")]
		public Components Components { get; set; }

		[XmlElement(ElementName = "power-storage")]
		public PowerStorage PowerStorage { get; set; }

		[XmlElement(ElementName = "production-progress")]
		public ProductionProgress ProductionProgress { get; set; }

		[XmlElement(ElementName = "water-storage")]
		public WaterStorage WaterStorage { get; set; }

		[XmlElement(ElementName = "resource-storage")]
		public ResourceStorage ResourceStorage { get; set; }

		[XmlElement(ElementName = "laser-charge")]
		public LaserCharge Lasercharge { get; set; }

		[XmlElement(ElementName = "links")]
		public Links Links { get; set; }

		[XmlElement(ElementName = "construction-materials")]
		public ConstructionMaterials ConstructionMaterials { get; set; }

		[XmlElement(ElementName = "pending-construction-costs")]
		public PendingConstructionCosts PendingConstructionCosts { get; set; }
	}
}
