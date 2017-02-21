using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "final-rotation")]
	public class FinalRotation
	{
		[XmlAttribute(AttributeName = "x")]
		public double X { get; set; }

		[XmlAttribute(AttributeName = "y")]
		public double Y { get; set; }

		[XmlAttribute(AttributeName = "z")]
		public double Z { get; set; }
	}
}