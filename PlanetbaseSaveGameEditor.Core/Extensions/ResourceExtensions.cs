using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Extensions
{
	public static class ResourceExtensions
	{

		public static SaveGame AddResource(this SaveGame input, ResourceType resourceType, int count = 1)
		{
			SaveGame saveGame = input;
			int currentId = saveGame.IdGenerator.NextId.Value;

			for (int i = 0; i < count; i++)
			{
				Resource resource = new Resource()
				{
					Condition = new ValueAttribute<double>() { Value = 1 },
					Durability = new ValueAttribute<double>() { Value = 1 },
					Id = new ValueAttribute<int>() { Value = currentId },
					Location = new ValueAttribute<int>() { Value = 1 },
					Orientation = new Coordinates() { X = 0, Y = 0, Z = 0 },
					Position = new Coordinates() { X = 0, Y = 0, Z = 0 },
					State = new ValueAttribute<int>() { Value = 1 },
					Traderid = new ValueAttribute<int>() { Value = -1 },
					Subtype = new ValueAttribute<int>() { Value = 0 },
					Type = resourceType
				};
				currentId++;
				saveGame.Resources.Resource.Add(resource);
			}

			saveGame.IdGenerator.NextId.Value = currentId;

			return saveGame;
		}
	}
}
