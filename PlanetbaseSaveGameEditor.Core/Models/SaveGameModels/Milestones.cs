using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "milestones")]
	public class Milestones
	{
		[XmlElement(ElementName = "milestone")]
		public List<ValueAttribute<String>> Milestone { get; set; }
	}
}