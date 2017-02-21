using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "ships")]
	public class Ships
	{
		[XmlElement(ElementName = "ship")]
		public Ship Ship { get; set; }
	}
}