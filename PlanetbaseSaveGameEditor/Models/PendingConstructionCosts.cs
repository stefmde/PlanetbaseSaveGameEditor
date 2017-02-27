using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class PendingConstructionCosts
	{
		public string ContainerName { get; set; }

		public List<Amount> Amount { get; set; }
	}
}