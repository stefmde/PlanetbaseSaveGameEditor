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

			foreach (Character character in saveGame.Characters.Character.Where(x => x.CharacterType == CharacterType.Colonist || x.CharacterType == CharacterType.Guest))
			{
				character.Health.Value = 1;
				character.Nutrition.Value = 1;
				character.Hydration.Value = 1;
				character.Oxygen.Value = 1;
				character.Sleep.Value = 1;
				character.Morale.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame HealAllBots(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (Character character in saveGame.Characters.Character.Where(x => x.CharacterType == CharacterType.Bot))
			{
				character.State.Value = 1;
				character.CharacterCondition.Value = 1;
				character.Integrity.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame HealAllCharacters(this SaveGame input)
		{
			return input.HealAllColonists().HealAllBots();
		}
	}
}
