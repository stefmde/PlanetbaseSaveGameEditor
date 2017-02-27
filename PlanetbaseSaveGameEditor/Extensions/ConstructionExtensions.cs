using System.Linq;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;

namespace PlanetbaseSaveGameEditor.Extensions
{
	public static class ConstructionExtensions
	{
		public static SaveGameCore RepairAllConstructions(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

			foreach (ConstructionCore construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypePowerCollector))
			{
				construction.Condition.Value = 1;
			}

			return saveGame;
		}

		public static SaveGameCore BuildAllConstructions(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

			foreach (ConstructionCore construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypeWaterTank))
			{
				construction.State.Value = 3;
				construction.Oxygen.Value = 1;
			}

			return saveGame;
		}

		public static SaveGameCore DoAllConstructions(this SaveGameCore input)
		{
			return input.RepairAllConstructions().BuildAllConstructions();
		}
	}
}
