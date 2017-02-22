using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public class BotCharacter : BaseCharacter
	{
		[XmlElement(ElementName = "Condition")]
		public ValueAttribute<Double> Condition { get; set; }

		[XmlElement(ElementName = "Integrity")]
		public ValueAttribute<Double> Integrity { get; set; }

		[XmlElement(ElementName = "integrity-decay-rate")]
		public ValueAttribute<Double> IntegrityDecayRate { get; set; }

		[XmlElement(ElementName = "loaded-resource")]
		public ValueAttribute<Int32> LoadedResource { get; set; }
	}
}
