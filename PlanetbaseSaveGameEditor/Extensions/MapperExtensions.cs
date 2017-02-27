using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Models;

namespace PlanetbaseSaveGameEditor.Extensions
{
	public static class MapperExtensions
	{
		public static SaveGame ConvertToSaveGame(this SaveGameCore saveGameCore)
		{
			SaveGame result = new SaveGame();



			return result;
		}

		public static SaveGameCore ConvertToSaveGameCore(this SaveGame saveGame)
		{
			SaveGameCore result = new SaveGameCore();



			return result;
		}
	}
}
