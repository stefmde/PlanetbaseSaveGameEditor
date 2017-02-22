using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	public class Cdata : IXmlSerializable
	{
		public string Value { get; set; }

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			Value = reader.ReadElementString();
		}
		public void WriteXml(XmlWriter writer)
		{
			writer.WriteCData(this.Value);
		}
	}
}
