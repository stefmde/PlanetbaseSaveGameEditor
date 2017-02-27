using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Amount
	{
		public ResourceType ResourceType { get; set; }

		public int Count { get; set; }
	}
}