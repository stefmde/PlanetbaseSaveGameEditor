using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "planet")]
	public class PlanetCore
	{
		[XmlElement(ElementName = "planet-index")]
		public ValueAttribute<Int32> PlanetIndex { get; set; }
	}
}