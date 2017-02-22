using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "character")]
	public class Character
	{
		[XmlAttribute(AttributeName = "type")]
		public CharacterType CharacterType { get; set; }


		[XmlElement(ElementName = "position")]
		public Coordinates Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Coordinates Orientation { get; set; }

		[XmlElement(ElementName = "location")]
		public ValueAttribute<Int32> Location { get; set; }

		[XmlElement(ElementName = "name")]
		public ValueAttribute<String> Name { get; set; }

		[XmlElement(ElementName = "specialization")]
		public ValueAttribute<SpecializationType> Specialization { get; set; }

		[XmlElement(ElementName = "status-flags")]
		public ValueAttribute<String> StatusFlags { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Double> State { get; set; }

		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }



		[XmlElement(ElementName = "wander-time")]
		public ValueAttribute<Double> WanderTime { get; set; }

		[XmlElement(ElementName = "Health")]
		public ValueAttribute<Double> Health { get; set; }

		[XmlElement(ElementName = "Nutrition")]
		public ValueAttribute<Double> Nutrition { get; set; }

		[XmlElement(ElementName = "Hydration")]
		public ValueAttribute<Double> Hydration { get; set; }

		[XmlElement(ElementName = "Oxygen")]
		public ValueAttribute<Double> Oxygen { get; set; }

		[XmlElement(ElementName = "Sleep")]
		public ValueAttribute<Double> Sleep { get; set; }

		[XmlElement(ElementName = "Morale")]
		public ValueAttribute<Double> Morale { get; set; }

		[XmlElement(ElementName = "gender")]
		public ValueAttribute<Int32> Gender { get; set; }

		[XmlElement(ElementName = "basic-meal-count")]
		public ValueAttribute<Int32> BasicMealCount { get; set; }

		[XmlElement(ElementName = "head-index")]
		public ValueAttribute<Int32> HeadIndex { get; set; }

		[XmlElement(ElementName = "skin-color-index")]
		public ValueAttribute<Int32> SkinColorIndex { get; set; }

		[XmlElement(ElementName = "hair-color-index")]
		public ValueAttribute<Int32> HairColorIndex { get; set; }

		[XmlElement(ElementName = "doctor")]
		public BoolValueAttribute Doctor { get; set; }

		[XmlElement(ElementName = "inmunity-to-contagion-time")]
		public ValueAttribute<Double> InmunityToContagionTime { get; set; }

		[XmlElement(ElementName = "Condition")]
		public ValueAttribute<Double> CharacterCondition { get; set; }

		[XmlElement(ElementName = "Integrity")]
		public ValueAttribute<Double> Integrity { get; set; }

		[XmlElement(ElementName = "integrity-decay-rate")]
		public ValueAttribute<Double> IntegrityDecayRate { get; set; }

		[XmlElement(ElementName = "fee")]
		public ValueAttribute<Int32> Fee { get; set; }

		[XmlElement(ElementName = "prestige")]
		public ValueAttribute<Int32> Prestige { get; set; }

		[XmlElement(ElementName = "agression-time")]
		public ValueAttribute<Double> AgressionTime { get; set; }

		[XmlElement(ElementName = "owned-ship-id")]
		public ValueAttribute<Int32> OwnedShipId { get; set; }

		[XmlElement(ElementName = "loaded-resource")]
		public ValueAttribute<Int32> LoadedResource { get; set; }
	}
}