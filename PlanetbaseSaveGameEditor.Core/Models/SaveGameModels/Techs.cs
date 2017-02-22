using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "techs")]
	public class Techs
	{
		[XmlElement(ElementName = "tech")]
		public List<ValueAttribute<String>> Tech { get; set; }
	}
}