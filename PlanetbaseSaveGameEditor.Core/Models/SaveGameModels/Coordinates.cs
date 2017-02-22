using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	public class Coordinates
	{
		[XmlAttribute(AttributeName = "x")]
		public double X { get; set; }

		[XmlAttribute(AttributeName = "y")]
		public double Y { get; set; }

		[XmlAttribute(AttributeName = "z")]
		public double Z { get; set; }
	}
}
