using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "owned-ship-id")]
	public class OwnedShipId
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}