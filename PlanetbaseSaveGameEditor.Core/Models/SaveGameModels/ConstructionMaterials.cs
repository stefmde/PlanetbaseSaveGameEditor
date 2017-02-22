using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "construction-materials")]
	public class ConstructionMaterials
	{
		[XmlElement(ElementName = "id")]
		public List<ValueAttribute<Int32>> Id { get; set; }
	}
}