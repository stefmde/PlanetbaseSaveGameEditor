using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "gender")]
	public class Gender
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}