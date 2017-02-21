using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "character")]
	public class Character
	{
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }
		[XmlElement(ElementName = "orientation")]
		public Orientation Orientation { get; set; }
		[XmlElement(ElementName = "location")]
		public Location Location { get; set; }
		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }
		[XmlElement(ElementName = "specialization")]
		public Specialization Specialization { get; set; }
		[XmlElement(ElementName = "status-flags")]
		public StatusFlags Statusflags { get; set; }
		[XmlElement(ElementName = "state")]
		public State State { get; set; }
		[XmlElement(ElementName = "id")]
		public Id Id { get; set; }
		[XmlElement(ElementName = "wander-time")]
		public WanderTime Wandertime { get; set; }
		[XmlElement(ElementName = "Health")]
		public Health Health { get; set; }
		[XmlElement(ElementName = "Nutrition")]
		public Nutrition Nutrition { get; set; }
		[XmlElement(ElementName = "Hydration")]
		public Hydration Hydration { get; set; }
		[XmlElement(ElementName = "Oxygen")]
		public Oxygen Oxygen { get; set; }
		[XmlElement(ElementName = "Sleep")]
		public Sleep Sleep { get; set; }
		[XmlElement(ElementName = "Morale")]
		public Morale Morale { get; set; }
		[XmlElement(ElementName = "gender")]
		public Gender Gender { get; set; }
		[XmlElement(ElementName = "basic-meal-count")]
		public BasicMealCount Basicmealcount { get; set; }
		[XmlElement(ElementName = "head-index")]
		public HeadIndex Headindex { get; set; }
		[XmlElement(ElementName = "skin-color-index")]
		public SkinColorIndex Skincolorindex { get; set; }
		[XmlElement(ElementName = "hair-color-index")]
		public HairColorIndex Haircolorindex { get; set; }
		[XmlElement(ElementName = "doctor")]
		public Doctor Doctor { get; set; }
		[XmlElement(ElementName = "inmunity-to-contagion-time")]
		public InmunityToContagionTime Inmunitytocontagiontime { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "Condition")]
		public CharacterCondition CharacterCondition { get; set; }
		[XmlElement(ElementName = "Integrity")]
		public Integrity Integrity { get; set; }
		[XmlElement(ElementName = "integrity-decay-rate")]
		public IntegrityDecayRate Integritydecayrate { get; set; }
	}
}