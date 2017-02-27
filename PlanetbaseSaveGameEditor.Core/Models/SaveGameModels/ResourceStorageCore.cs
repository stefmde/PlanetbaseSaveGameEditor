using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource-storage")]
	public class ResourceStorageCore
	{
		[XmlElement(ElementName = "slot")]
		public List<SlotCore> Slot { get; set; }
	}
}