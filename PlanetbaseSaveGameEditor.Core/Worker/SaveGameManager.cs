using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models;

namespace PlanetbaseSaveGameEditor.Core.Worker
{
	public static class SaveGameManager
	{
		public static string SerializeToXml(SaveGame saveGame)
		{
			string data;
			XmlSerializer x = new XmlSerializer(saveGame.GetType());
			using (MemoryStream ms = new MemoryStream())
			{
				x.Serialize(ms, saveGame);
				ms.Position = 0;
				using (StreamReader sr = new StreamReader(ms, Encoding.Unicode))
				{
					data = sr.ReadToEnd();
				}
			}

			return data;
		}

		public static SaveGame DeSerializeFromXml(string xml)
		{
			XmlSerializer x = new XmlSerializer(typeof(SaveGame));
			byte[] xmlBytes = Encoding.Unicode.GetBytes(xml);
			using (MemoryStream ms = new MemoryStream(xmlBytes))
			{
				return (SaveGame)x.Deserialize(ms);
			}
		}
	}
}
