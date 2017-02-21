using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
	namespace Xml2CSharp
	{
		[XmlRoot(ElementName = "save-game")]
		public class Savegame
		{
			[XmlElement(ElementName = "id-generator")]
			public IdGenerator Idgenerator { get; set; }
			[XmlElement(ElementName = "planet")]
			public Planet Planet { get; set; }
			[XmlElement(ElementName = "milestones")]
			public string Milestones { get; set; }
			[XmlElement(ElementName = "techs")]
			public string Techs { get; set; }
			[XmlElement(ElementName = "environment")]
			public Environment Environment { get; set; }
			[XmlElement(ElementName = "terrain")]
			public Terrain Terrain { get; set; }
			[XmlElement(ElementName = "camera")]
			public Camera Camera { get; set; }
			[XmlElement(ElementName = "sandstorm")]
			public Sandstorm Sandstorm { get; set; }
			[XmlElement(ElementName = "blizzard")]
			public Blizzard Blizzard { get; set; }
			[XmlElement(ElementName = "solar-flare")]
			public Solarflare Solarflare { get; set; }
			[XmlElement(ElementName = "colony")]
			public Colony Colony { get; set; }
			[XmlElement(ElementName = "ship-manager")]
			public Shipmanager Shipmanager { get; set; }
			[XmlElement(ElementName = "stats")]
			public Stats Stats { get; set; }
			[XmlElement(ElementName = "visitor-events")]
			public VisitorEvents Visitorevents { get; set; }
			[XmlElement(ElementName = "game-hints")]
			public GameHints Gamehints { get; set; }
			[XmlElement(ElementName = "manufacture-limits")]
			public ManufactureLimits Manufacturelimits { get; set; }
			[XmlElement(ElementName = "challenge-manager")]
			public ChallengeManager Challengemanager { get; set; }
			[XmlElement(ElementName = "constructions")]
			public string Constructions { get; set; }
			[XmlElement(ElementName = "characters")]
			public Characters Characters { get; set; }
			[XmlElement(ElementName = "resources")]
			public Resources Resources { get; set; }
			[XmlElement(ElementName = "ships")]
			public Ships Ships { get; set; }
			[XmlElement(ElementName = "interactions")]
			public string Interactions { get; set; }
			[XmlElement(ElementName = "screenshot")]
			public string Screenshot { get; set; }
			[XmlAttribute(AttributeName = "version")]
			public string Version { get; set; }
		}

	}

}
