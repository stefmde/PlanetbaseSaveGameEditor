using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "characters")]
	public class Characters
	{
		[XmlElement(ElementName = "character")]
		public List<Character> Character { get; set; }
	}
}