using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "constructions")]
	public class Constructions
	{
		[XmlElement(ElementName = "construction")]
		public List<Construction> Construction { get; set; }
	}

}
