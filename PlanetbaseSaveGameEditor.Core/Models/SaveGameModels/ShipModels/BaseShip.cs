using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.ShipModels
{
	public class BaseShip
	{
		[XmlElement(ElementName = "id")]
		public ValueAttribute<Int32> Id { get; set; }

		[XmlElement(ElementName = "position")]
		public Coordinates Position { get; set; }

		[XmlElement(ElementName = "orientation")]
		public Coordinates Orientation { get; set; }

		[XmlElement(ElementName = "state")]
		public ValueAttribute<Int32> State { get; set; }
	}
}
