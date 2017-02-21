using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "basic-meal-count")]
	public class BasicMealCount
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}