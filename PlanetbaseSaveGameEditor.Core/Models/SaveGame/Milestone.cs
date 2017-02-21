﻿using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "milestone")]
	public class Milestone
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}