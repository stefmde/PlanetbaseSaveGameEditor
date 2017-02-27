using System.Collections.Generic;
using System.IO;
using System.Linq;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Models;

namespace PlanetbaseSaveGameEditor.Worker
{
	public static class SaveGameManager
	{
		public static List<SaveGameFile> GetSaveGameFiles(string rootPath)
		{
			List<SaveGameFile> saveGameFiles = new List<SaveGameFile>();

			DirectoryInfo directoryInfo = new DirectoryInfo(rootPath);
			FileInfo[] files = directoryInfo.GetFiles("*.sav");

			foreach (FileInfo file in files)
			{
				SaveGameFile saveGameFile = new SaveGameFile()
				{
					RootPath = rootPath,
					LastChanged = file.LastWriteTime,
					Name = file.Name,
					SizeInKb = file.Length / 1024
				};

				saveGameFiles.Add(saveGameFile);
			}

			saveGameFiles = saveGameFiles.OrderByDescending(x => x.LastChanged).ToList();

			return saveGameFiles;
		}


		public static bool Save(this SaveGame saveGame)
		{
			return SaveSaveGame(saveGame);
		}

		public static bool SaveSaveGame(SaveGame saveGame)
		{
			//Todo: Implement
		}


		public static SaveGameFile Load(this SaveGameFile saveGameFile)
		{
			return LoadSaveGame(saveGameFile.FullName);
		}

		public static SaveGameFile LoadSaveGame(SaveGameFile saveGameFile)
		{
			return LoadSaveGame(saveGameFile.FullName);
		}

		public static SaveGameFile LoadSaveGame(string filePath)
		{
			//Todo: Implement
		}



	}
}
