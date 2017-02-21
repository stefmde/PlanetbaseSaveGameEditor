using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "loaded-resource")]
	public class LoadedResource
	{
		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}
}