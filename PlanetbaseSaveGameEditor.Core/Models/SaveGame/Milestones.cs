using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "milestones")]
	public class Milestones
	{
		[XmlElement(ElementName = "milestone")]
		public List<Milestone> Milestone { get; set; }
	}
}