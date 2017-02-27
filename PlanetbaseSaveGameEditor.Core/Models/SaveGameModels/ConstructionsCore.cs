using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "constructions")]
	public class ConstructionsCore
	{
		[XmlElement(ElementName = "construction")]
		public List<ConstructionCore> Construction { get; set; }
	}

}
