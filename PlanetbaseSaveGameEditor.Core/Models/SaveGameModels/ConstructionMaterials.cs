using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "construction-materials")]
	public class ConstructionMaterials
	{
		[XmlElement(ElementName = "id")]
		public List<Id> Id { get; set; }
	}
}