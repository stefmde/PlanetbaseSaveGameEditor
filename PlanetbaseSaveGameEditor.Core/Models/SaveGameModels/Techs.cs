using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "techs")]
	public class Techs
	{
		[XmlElement(ElementName = "tech")]
		public List<Tech> Tech { get; set; }
	}
}