using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "game-hints")]
	public class GameHints
	{
		[XmlElement(ElementName = "shown-hints")]
		public ValueAttribute<String> ShownHints { get; set; }
	}
}