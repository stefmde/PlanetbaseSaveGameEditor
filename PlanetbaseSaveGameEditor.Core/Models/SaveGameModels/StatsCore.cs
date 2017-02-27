using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "stats")]
	public class StatsCore
	{
		[XmlElement(ElementName = "counter")]
		public List<CounterCore> Counter { get; set; }
	}
}