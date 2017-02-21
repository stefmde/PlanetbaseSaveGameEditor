using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "Health")]
	public class Health
	{
		[XmlAttribute(AttributeName = "value")]
		public double Value { get; set; }
	}
}