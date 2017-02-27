using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public class GuestCharacter : ColonistCharacter
	{
		public GuestCharacter()
		{
			CharacterType = CharacterType.Guest;
		}

		[XmlElement(ElementName = "fee")]
		public ValueAttribute<Int32> Fee { get; set; }

		[XmlElement(ElementName = "prestige")]
		public ValueAttribute<Int32> Prestige { get; set; }

		[XmlElement(ElementName = "agression-time")]
		public ValueAttribute<Double> AgressionTime { get; set; }

		[XmlElement(ElementName = "owned-ship-id")]
		public ValueAttribute<Int32> OwnedShipId { get; set; }
	}
}
