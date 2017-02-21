using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "slot")]
	public class Slot
	{
		[XmlElement(ElementName = "position")]
		public Position Position { get; set; }

		[XmlElement(ElementName = "max-height")]
		public MaxHeight MaxHeight { get; set; }

		[XmlElement(ElementName = "resource")]
		public List<Resource> Resource { get; set; }
	}
}