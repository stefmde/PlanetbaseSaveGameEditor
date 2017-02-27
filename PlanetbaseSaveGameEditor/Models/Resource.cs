using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Resource
	{
		public ResourceType Type { get; set; }


		public int Id { get; set; }

		public int Traderid { get; set; }

		public Coordinates Position { get; set; }

		public Coordinates Orientation { get; set; }

		public int State { get; set; }

		public int Location { get; set; }

		public int Subtype { get; set; }

		public double Condition { get; set; }

		public double Durability { get; set; }
	}
}