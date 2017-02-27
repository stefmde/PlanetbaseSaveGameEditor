using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Slot
	{
		public Coordinates Position { get; set; }

		public double MaxHeight { get; set; }

		public List<Resource> Resource { get; set; }
	}
}