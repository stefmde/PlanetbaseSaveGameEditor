using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "amount")]
	public class AmountCore
	{
		//[XmlAttribute(AttributeName = "value")]
		//public string Value { get; set; }

		[XmlElement(ElementName = "resource-type")]
		public ValueAttribute<ResourceType> ResourceType { get; set; }

		[XmlElement(ElementName = "amount")]
		public ValueAttribute<Int32> ValueAmount { get; set; }
	}
}