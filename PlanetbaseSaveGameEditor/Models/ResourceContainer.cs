using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class ResourceContainer
	{
		public int Capacity { get; set; }

		public List<Resource> Resource { get; set; }
	}
}