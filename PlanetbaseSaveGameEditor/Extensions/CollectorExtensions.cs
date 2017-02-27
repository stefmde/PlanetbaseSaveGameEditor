using System.Linq;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;

namespace PlanetbaseSaveGameEditor.Extensions
{
	public static class CollectorExtensions
	{
		public static SaveGameCore FillAllPowerCollectors(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

			foreach (ConstructionCore construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypePowerCollector))
			{
				if (construction.SizeIndex.Value == 2)
				{
					construction.PowerStorage.Value = 12500000;
				}
				else if (construction.SizeIndex.Value == 1)
				{
					construction.PowerStorage.Value = 7500000;
				}
				else if (construction.SizeIndex.Value == 0)
				{
					construction.PowerStorage.Value = 5000000;
				}
			}

			return saveGame;
		}

		public static SaveGameCore FillAllWatterTanks(this SaveGameCore input)
		{
			SaveGameCore saveGame = input;

			foreach (ConstructionCore construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypeWaterTank))
			{
				if (construction.SizeIndex.Value == 2)
				{
					construction.WaterStorage.Value = 600000;
				}
				else if (construction.SizeIndex.Value == 0)
				{
					construction.WaterStorage.Value = 400000;
				}
			}

			return saveGame;
		}

		public static SaveGameCore FillAllCollectors(this SaveGameCore input)
		{
			return input.FillAllPowerCollectors().FillAllWatterTanks();
		}
	}
}
