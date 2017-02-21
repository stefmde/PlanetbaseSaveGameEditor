using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "constructions")]
	public class Constructions
	{
		[XmlElement(ElementName = "construction")]
		public List<Construction> Construction { get; set; }
	}

}
