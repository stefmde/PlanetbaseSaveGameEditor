using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Extensions
{
	public static class ConstructionExtensions
	{
		public static SaveGame RepairAllConstructions(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (Construction construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypePowerCollector))
			{
				construction.Condition.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame BuildAllConstructions(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (Construction construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypeWaterTank))
			{
				construction.State.Value = 3;
				construction.Oxygen.Value = 1;
			}

			return saveGame;
		}

		public static SaveGame DoAllConstructions(this SaveGame input)
		{
			return input.RepairAllConstructions().BuildAllConstructions();
		}
	}
}
