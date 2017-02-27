using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public class BotCharacter : BaseCharacter
	{
		public BotCharacter()
		{
			CharacterType = CharacterType.Bot;
		}

		[XmlElement(ElementName = "Condition")]
		public ValueAttribute<Double> Condition { get; set; }

		[XmlElement(ElementName = "Integrity")]
		public ValueAttribute<Double> Integrity { get; set; }

		[XmlElement(ElementName = "integrity-decay-rate")]
		public ValueAttribute<Double> IntegrityDecayRate { get; set; }

		[XmlElement(ElementName = "loaded-resource")]
		public ValueAttribute<Int32> LoadedResource { get; set; }

		[XmlElement(ElementName = "specialization")]
		public ValueAttribute<BotSpecializationType> Specialization { get; set; }
	}
}
