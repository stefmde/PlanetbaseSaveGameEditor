﻿using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public class ColonistCharacter : BaseCharacter
	{
		public ColonistCharacter()
		{
			CharacterType = CharacterType.Colonist;
		}

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

		[XmlElement(ElementName = "condition")]
		public HumanConditionCore Condition { get; set; }

		[XmlElement(ElementName = "specialization")]
		public ValueAttribute<ColonistSpecializationType> Specialization { get; set; }
	}
}
