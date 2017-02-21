using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGame
{
	[XmlRoot(ElementName = "pending-construction-costs")]
	public class PendingConstructionCosts
	{
		[XmlElement(ElementName = "container-name")]
		public ContainerName ContainerName { get; set; }

		[XmlElement(ElementName = "amount")]
		public List<Amount> Amount { get; set; }
	}
}