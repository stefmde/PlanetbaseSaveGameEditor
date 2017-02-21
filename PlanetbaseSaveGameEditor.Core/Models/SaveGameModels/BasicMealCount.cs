using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "basic-meal-count")]
	public class BasicMealCount
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}