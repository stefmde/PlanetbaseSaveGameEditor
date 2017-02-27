using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Camera
	{
		public double Height { get; set; }

		public Coordinates Position { get; set; }

		public Coordinates Orientation { get; set; }
	}
}