using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Resources
	{
		public List<Resource> Resource { get; set; }

		public InmaterialResources InmaterialResources { get; set; }
	}
}