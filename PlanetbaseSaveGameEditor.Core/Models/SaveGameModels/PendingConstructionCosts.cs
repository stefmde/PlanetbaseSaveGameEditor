using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "pending-construction-costs")]
	public class PendingConstructionCosts
	{
		[XmlElement(ElementName = "container-name")]
		public ValueAttribute<String> ContainerName { get; set; }

		[XmlElement(ElementName = "amount")]
		public List<Amount> Amount { get; set; }
	}
}