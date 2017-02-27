using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;

namespace PlanetbaseSaveGameEditor.Models
{
	public class SaveGame
	{
		public int GameVersion { get; set; }

		public int NextId { get; set; }

		public int NextBotId { get; set; }


		public int PlanetIndex { get; set; }

		public List<string> Milestones { get; set; }

		public List<string> Technologies { get; set; }

		public Environment Environment { get; set; }

		public int TerrainSeed { get; set; }

		public Camera Camera { get; set; }

		public EnvironmentEvent Sandstorm { get; set; }

		public EnvironmentEvent Blizzard { get; set; }

		public EnvironmentEvent SolarFlare { get; set; }

		public Colony Colony { get; set; }

		public ShipManager ShipManager { get; set; }

		public List<Counter> Stats { get; set; }

		public double NextEventTime { get; set; }

		public List<VisitorEvent> VisitorEvents { get; set; }

		public string ShownGameHints { get; set; }

		public List<string> MeteorSeeds { get; set; }

		public ManufactureLimits ManufactureLimits { get; set; }

		public string ChallengeId { get; set; }

		public List<Construction> Constructions { get; set; }

		public List<BaseCharacter> Characters { get; set; }

		public Resources Resources { get; set; }

		public List<Ship> Ships { get; set; }

		public List<Interaction> Interactions { get; set; }

		public string Screenshot { get; set; }

	}
}
