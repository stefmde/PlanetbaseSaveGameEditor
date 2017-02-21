using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "doctor")]
	public class Doctor
	{
		[XmlAttribute(AttributeName = "value")]
		public bool Value { get; set; }
	}
}