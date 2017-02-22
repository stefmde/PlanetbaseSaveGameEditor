using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource-container")]
	public class ResourceContainer
	{
		[XmlElement(ElementName = "capacity")]
		public ValueAttribute<Int32> Capacity { get; set; }

		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }
	}
}