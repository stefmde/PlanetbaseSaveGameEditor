using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class VisitorEvent
	{
		public string Type { get; set; }

		public int VisitorCount { get; set; }
	}
}