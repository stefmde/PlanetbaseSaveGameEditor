using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "components")]
	public class ComponentsCore
	{
		[XmlElement(ElementName = "component")]
		public List<ComponentCore> Components2 { get; set; }
	}
}