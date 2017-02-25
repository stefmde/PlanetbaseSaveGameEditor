using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Enums;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "amount")]
	public class Amount
	{
		//[XmlAttribute(AttributeName = "value")]
		//public string Value { get; set; }

		[XmlElement(ElementName = "resource-type")]
		public ValueAttribute<ResourceType> ResourceType { get; set; }

		[XmlElement(ElementName = "amount")]
		public ValueAttribute<Int32> ValueAmount { get; set; }
	}
}