using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource-container")]
	public class ResourceContainer
	{
		[XmlElement(ElementName = "capacity")]
		public Capacity Capacity { get; set; }

		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }
	}
}