using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "resource-storage")]
	public class ResourceStorage
	{
		[XmlElement(ElementName = "slot")]
		public List<Slot> Slot { get; set; }
	}
}