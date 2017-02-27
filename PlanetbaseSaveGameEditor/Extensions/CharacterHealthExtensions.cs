using System.Linq;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;

namespace PlanetbaseSaveGameEditor.Extensions
{
	public static class CharacterHealthExtensions
	{
		public static SaveGameCore HealAllColonists(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

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

		public static SaveGameCore RepairAllBots(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

			foreach (BaseCharacter character in saveGame.Characters.Where(x => x.CharacterType == CharacterType.Bot))
			{
				BotCharacter botCharacter = (BotCharacter)character;
				botCharacter.State.Value = 1;
				botCharacter.Condition.Value = 1;
				botCharacter.Integrity.Value = 1;
			}

			return saveGame;
		}

		public static SaveGameCore HealAllCharacters(this SaveGameCore input)
		{
			return input.HealAllColonists().RepairAllBots();
		}
	}
}
