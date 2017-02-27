using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "counter")]
	public class CounterCore
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }


		[XmlElement(ElementName = "type-name")]
		public ValueAttribute<String> TypeName { get; set; }

		[XmlElement(ElementName = "counts")]
		public ValueAttribute<String> Counts { get; set; }
	}
}