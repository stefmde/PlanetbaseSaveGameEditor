using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resources")]
	public class ResourcesCore
	{
		[XmlElement(ElementName = "resource")]
		public List<ResourceCore> Resource { get; set; }

		[XmlElement(ElementName = "inmaterial-resources")]
		public InmaterialResourcesCore InmaterialResources { get; set; }
	}
}