using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.ShipModels;
using PlanetbaseSaveGameEditor.Core.Worker;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	// Original                        -> After Serialization
	// <power-storage value="2E+07" /> -> <power-storage value="20000000" />
	// Same for water?
	// <screenshot><![CDATA[/9j/4AAQS





	[XmlRoot(ElementName = "save-game")]
	public class SaveGameCore
	{
		[XmlAttribute(AttributeName = "version")]
		public int Version { get; set; }


		[XmlElement(ElementName = "id-generator")]
		public IdGeneratorCore IdGenerator { get; set; }

		[XmlElement(ElementName = "planet")]
		public PlanetCore Planet { get; set; }

		[XmlElement(ElementName = "milestones")]
		public MilestonesCore Milestones { get; set; }

		[XmlElement(ElementName = "techs")]
		public TechsCore Techs { get; set; }

		[XmlElement(ElementName = "environment")]
		public EnvironmentCore Environment { get; set; }

		[XmlElement(ElementName = "terrain")]
		public TerrainCore Terrain { get; set; }

		[XmlElement(ElementName = "camera")]
		public CameraCore Camera { get; set; }

		[XmlElement(ElementName = "sandstorm")]
		public SandstormCore Sandstorm { get; set; }

		[XmlElement(ElementName = "blizzard")]
		public BlizzardCore Blizzard { get; set; }

		[XmlElement(ElementName = "solar-flare")]
		public SolarFlareCore SolarFlare { get; set; }

		[XmlElement(ElementName = "colony")]
		public ColonyCore Colony { get; set; }

		[XmlElement(ElementName = "ship-manager")]
		public ShipManagerCore ShipManager { get; set; }

		[XmlElement(ElementName = "stats")]
		public StatsCore Stats { get; set; }

		[XmlElement(ElementName = "visitor-events")]
		public VisitorEventsCore VisitorEvents { get; set; }

		[XmlElement(ElementName = "game-hints")]
		public GameHintsCore GameHints { get; set; }

		[XmlElement(ElementName = "meteor-manager")]
		public MeteorManagerCore MeteorManager { get; set; }

		[XmlElement(ElementName = "manufacture-limits")]
		public ManufactureLimitsCore ManufactureLimits { get; set; }

		[XmlElement(ElementName = "challenge-manager")]
		public ChallengeManagerCore ChallengeManager { get; set; }

		[XmlElement(ElementName = "constructions")]
		public ConstructionsCore Constructions { get; set; }

		[XmlArray("characters")]
		[XmlArrayItem("character", Type = typeof(AbstactSerializer<BaseCharacter>))]
		public List<BaseCharacter> Characters { get; set; }

		[XmlElement(ElementName = "resources")]
		public ResourcesCore Resources { get; set; }

		[XmlElement(ElementName = "ships")]
		public Ships Ships { get; set; }

		[XmlElement(ElementName = "interactions")]
		public InteractionsCore Interactions { get; set; }

		[XmlElement(ElementName = "screenshot")]
		public CdataCore Screenshot { get; set; }
	}
}
