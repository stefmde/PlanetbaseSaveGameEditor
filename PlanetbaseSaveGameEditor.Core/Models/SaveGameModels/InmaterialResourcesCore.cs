using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "inmaterial-resources")]
	public class InmaterialResourcesCore
	{
		[XmlElement(ElementName = "container-name")]
		public ValueAttribute<String> Containername { get; set; }

		[XmlElement(ElementName = "amount")]
		public AmountCore Amount { get; set; }
	}
}