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
	public static class CollectorExtensions
	{
		public static SaveGame FillAllPowerCollectors(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (Construction construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypePowerCollector))
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

		public static SaveGame FillAllWatterCollectors(this SaveGame input)
		{
			SaveGame saveGame = input;

			foreach (Construction construction in saveGame.Constructions.Construction.Where(x => x.ModuleType != null && x.ModuleType.Value == ModuleType.ModuleTypeWaterTank))
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

		public static SaveGame FillAllCollectors(this SaveGame input)
		{
			return input.FillAllPowerCollectors().FillAllWatterCollectors();
		}
	}
}
