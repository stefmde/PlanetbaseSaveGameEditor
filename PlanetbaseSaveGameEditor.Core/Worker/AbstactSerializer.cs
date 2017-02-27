using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Worker
{
	public class AbstactSerializer<TAbstractType> : IXmlSerializable
	{
		public static implicit operator TAbstractType(AbstactSerializer<TAbstractType> instance)
		{
			return instance.Data;
		}

		public static implicit operator AbstactSerializer<TAbstractType>(TAbstractType instance)
		{
			return instance == null ? null : new AbstactSerializer<TAbstractType>(instance);
		}

		public TAbstractType Data { get; set; }
		public AbstactSerializer()
		{
		}

		public AbstactSerializer(TAbstractType data)
		{
			Data = data;
		}

		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			string value = reader.GetAttribute("type") + "Character";
			Type type = Type.GetType(string.Format("{0}.{1}", "PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels", value));
			if (type != null)
			{
				XmlRootAttribute xRoot = new XmlRootAttribute();
				xRoot.ElementName = "character";
				xRoot.IsNullable = true;
				Data = (TAbstractType)new XmlSerializer(type, xRoot).Deserialize(reader);
			}
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteAttributeString("type", Data.GetType().Name.Replace("Character", ""));

			XmlDocument xml = new XmlDocument();
			xml.LoadXml(FileManager.SerializeToXml(Data));
			XmlNodeList nodes = xml.SelectNodes("./*");

			if (nodes != null)
			{
				foreach (XmlNode node in nodes)
				{
					writer.WriteRaw(node.InnerXml + Environment.NewLine);
				}
			}
		}
	}
}
