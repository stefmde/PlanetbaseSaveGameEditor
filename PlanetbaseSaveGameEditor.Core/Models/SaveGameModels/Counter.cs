using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "counter")]
	public class Counter
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "type-name")]
		public TypeName TypeName { get; set; }

		[XmlElement(ElementName = "counts")]
		public Counts Counts { get; set; }
	}
}