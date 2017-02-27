using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Extensions
{
	public static class ResourceExtensions
	{

		public static SaveGameCore AddResource(this SaveGameCore input, ResourceType resourceType, int count = 1)
		{
			SaveGameCore saveGame = input;
			int currentId = saveGame.IdGenerator.NextId.Value;

			for (int i = 0; i < count; i++)
			{
				ResourceCore resource = new ResourceCore()
				{
					Condition = new ValueAttribute<double>() { Value = 1 },
					Durability = new ValueAttribute<double>() { Value = 1 },
					Id = new ValueAttribute<int>() { Value = currentId },
					Location = new ValueAttribute<int>() { Value = 1 },
					Orientation = new CoordinatesCore() { X = 0, Y = 0, Z = 0 },
					Position = new CoordinatesCore() { X = 0, Y = 0, Z = 0 },
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
