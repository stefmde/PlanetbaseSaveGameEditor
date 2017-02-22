﻿using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	public class HumanCondition
	{
		[XmlAttribute(AttributeName = "type")]
		public HumanConditionType Type { get; set; }


		[XmlElement(ElementName = "time")]
		public ValueAttribute<Double> Time { get; set; }

		[XmlElement(ElementName = "condition-time")]
		public ValueAttribute<Double> ConditionTime { get; set; }

		[XmlElement(ElementName = "contagion-time")]
		public ValueAttribute<Double> ContagionTime { get; set; }
	}
}