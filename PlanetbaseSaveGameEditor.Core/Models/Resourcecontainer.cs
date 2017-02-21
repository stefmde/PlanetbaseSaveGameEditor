using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "resource-container")]
	public class ResourCecontainer
	{
		[XmlElement(ElementName = "capacity")]
		public Capacity Capacity { get; set; }
		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }
	}
}