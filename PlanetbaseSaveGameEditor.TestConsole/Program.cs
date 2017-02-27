using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetbaseSaveGameEditor.Core.Extensions;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Worker;

namespace PlanetbaseSaveGameEditor.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\Solution Items\SaveGame Samples\save9.sav";

			string fileContent = File.ReadAllText(filePath);

			SaveGameCore saveGame = FileManager.DeSerializeFromXml<SaveGameCore>(fileContent).FillAllCollectors().HealAllCharacters().DoAllConstructions();

			string saveGameXml = FileManager.SerializeToXml(saveGame);

			Console.ReadLine();
		}
	}
}
