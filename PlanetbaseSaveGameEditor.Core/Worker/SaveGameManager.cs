﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
				{
					OmitXmlDeclaration = true,
					ConformanceLevel = ConformanceLevel.Auto,
					Indent = true
				};

				XmlWriter xmlWriter = XmlWriter.Create(ms, xmlWriterSettings);
				XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
				xmlSerializerNamespaces.Add("", "");

				x.Serialize(xmlWriter, saveGame, xmlSerializerNamespaces);
				ms.Position = 0;
				using (StreamReader sr = new StreamReader(ms, Encoding.UTF8))
				{
					data = sr.ReadToEnd();
				}
			}

			return data;
		}

		public static SaveGame DeSerializeFromXml(string xml)
		{
			XmlSerializer x = new XmlSerializer(typeof(SaveGame));
			byte[] xmlBytes = Encoding.UTF8.GetBytes(xml);
			using (MemoryStream ms = new MemoryStream(xmlBytes))
			{
				return (SaveGame)x.Deserialize(ms);
			}
		}
	}
}
