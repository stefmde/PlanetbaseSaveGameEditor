using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	public class CdataCore : IXmlSerializable
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
