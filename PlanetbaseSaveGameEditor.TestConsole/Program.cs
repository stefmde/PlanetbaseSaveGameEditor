using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Worker;

namespace PlanetbaseSaveGameEditor.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"F:\Drive\OneDrive\Dokumente\Planetbase\Saves\save13.xml";

			string fileContent = File.ReadAllText(filePath);

			SaveGame saveGame = SaveGameManager.DeSerializeFromXml(fileContent);


			Console.ReadLine();
		}
	}
}
