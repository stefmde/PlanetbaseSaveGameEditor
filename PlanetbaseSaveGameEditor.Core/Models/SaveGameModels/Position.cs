using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "position")]
	public class Position
	{
		[XmlAttribute(AttributeName = "x")]
		public double X { get; set; }

		[XmlAttribute(AttributeName = "y")]
		public double Y { get; set; }

		[XmlAttribute(AttributeName = "z")]
		public double Z { get; set; }
	}
}