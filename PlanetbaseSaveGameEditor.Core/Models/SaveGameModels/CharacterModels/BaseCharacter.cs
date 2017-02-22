using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels
{
	public class BaseCharacter
	{
		[XmlElement(ElementName = "position")]
		public Coordinates Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Coordinates Orientation { get; set; }

		[XmlElement(ElementName = "location")]
		public ValueAttribute<Int32> Location { get; set; }

		[XmlElement(ElementName = "name")]
		public ValueAttribute<String> Name { get; set; }

		[XmlElement(ElementName = "specialization")]
		public ValueAttribute<SpecializationType> Specialization { get; set; }

		[XmlElement(ElementName = "status-flags")]
		public ValueAttribute<String> StatusFlags { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Double> State { get; set; }

		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "wander-time")]
		public ValueAttribute<Double> WanderTime { get; set; }
	}
}
