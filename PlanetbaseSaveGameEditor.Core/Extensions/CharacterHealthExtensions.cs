using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Extensions
{
	public static class CharacterHealthExtensions
	{
		public static SaveGame HealAllColonists(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (BaseCharacter character in saveGame.Characters.Where(x => x.CharacterType == CharacterType.Colonist || x.CharacterType == CharacterType.Guest))
			{
				ColonistCharacter colonistCharacter = (ColonistCharacter)character;
				colonistCharacter.Health.Value = 1;
				colonistCharacter.Nutrition.Value = 1;
				colonistCharacter.Hydration.Value = 1;
				colonistCharacter.Oxygen.Value = 1;
				colonistCharacter.Sleep.Value = 1;
				colonistCharacter.Morale.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame HealAllBots(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (BaseCharacter character in saveGame.Characters.Where(x => x.CharacterType == CharacterType.Bot))
			{
				BotCharacter botCharacter = (BotCharacter)character;
				botCharacter.State.Value = 1;
				botCharacter.Condition.Value = 1;
				botCharacter.Integrity.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame HealAllCharacters(this SaveGame input)
		{
			return input.HealAllColonists().HealAllBots();
		}
	}
}
