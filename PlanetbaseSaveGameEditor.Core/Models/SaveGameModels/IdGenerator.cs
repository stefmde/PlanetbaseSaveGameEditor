using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "id-generator")]
	public class IdGenerator
	{
		[XmlElement(ElementName = "next-id")]
		public ValueAttribute<Int32> NextId { get; set; }

		[XmlElement(ElementName = "next-bot-id")]
		public ValueAttribute<Int32> NextBotId { get; set; }
	}
}