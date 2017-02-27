using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "terrain")]
	public class TerrainCore
	{
		[XmlElement(ElementName = "seed")]
		public ValueAttribute<Int32> Seed { get; set; }
	}
}