using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resources")]
	public class Resources
	{
		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }

		[XmlElement(ElementName = "inmaterial-resources")]
		public InmaterialResources InmaterialResources { get; set; }
	}
}