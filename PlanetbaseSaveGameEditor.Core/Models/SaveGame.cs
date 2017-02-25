﻿using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.ShipModels;
using PlanetbaseSaveGameEditor.Core.Worker;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	// Original                        -> After Serialization
	// <power-storage value="2E+07" /> -> <power-storage value="20000000" />
	// Same for water?
	// <screenshot><![CDATA[/9j/4AAQS





	[XmlRoot(ElementName = "save-game")]
	public class SaveGame
	{
		[XmlAttribute(AttributeName = "version")]
		public int Version { get; set; }


		[XmlElement(ElementName = "id-generator")]
		public IdGenerator IdGenerator { get; set; }

		[XmlElement(ElementName = "planet")]
		public Planet Planet { get; set; }

		[XmlElement(ElementName = "milestones")]
		public Milestones Milestones { get; set; }

		[XmlElement(ElementName = "techs")]
		public Techs Techs { get; set; }

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
		public SolarFlare SolarFlare { get; set; }

		[XmlElement(ElementName = "colony")]
		public Colony Colony { get; set; }

		[XmlElement(ElementName = "ship-manager")]
		public ShipManager ShipManager { get; set; }

		[XmlElement(ElementName = "stats")]
		public Stats Stats { get; set; }

		[XmlElement(ElementName = "visitor-events")]
		public VisitorEvents VisitorEvents { get; set; }

		[XmlElement(ElementName = "game-hints")]
		public GameHints GameHints { get; set; }

		[XmlElement(ElementName = "meteor-manager")]
		public MeteorManager MeteorManager { get; set; }

		[XmlElement(ElementName = "manufacture-limits")]
		public ManufactureLimits ManufactureLimits { get; set; }

		[XmlElement(ElementName = "challenge-manager")]
		public ChallengeManager ChallengeManager { get; set; }

		[XmlElement(ElementName = "constructions")]
		public Constructions Constructions { get; set; }

		[XmlArray("characters")]
		[XmlArrayItem("character", Type = typeof(AbstactSerializer<BaseCharacter>))]
		public List<BaseCharacter> Characters { get; set; }

		[XmlElement(ElementName = "resources")]
		public Resources Resources { get; set; }

		[XmlElement(ElementName = "ships")]
		public Ships Ships { get; set; }

		[XmlElement(ElementName = "interactions")]
		public Interactions Interactions { get; set; }

		[XmlElement(ElementName = "screenshot")]
		public Cdata Screenshot { get; set; }
	}
}
