using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "stats")]
	public class Stats
	{
		[XmlElement(ElementName = "counter")]
		public List<Counter> Counter { get; set; }
	}
}