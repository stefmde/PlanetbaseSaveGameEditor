using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "components")]
	public class Components
	{
		[XmlElement(ElementName = "component")]
		public List<Component> Components2 { get; set; }
	}
}