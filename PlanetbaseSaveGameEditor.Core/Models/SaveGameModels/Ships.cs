using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "ships")]
	public class Ships
	{
		[XmlElement(ElementName = "ship")]
		public List<Ship> ShipsList { get; set; }
	}
}