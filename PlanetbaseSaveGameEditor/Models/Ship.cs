using System;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Ship
	{
		public ShipType Type { get; set; }


		public int Id { get; set; }

		public Coordinates Position { get; set; }

		public Coordinates Orientation { get; set; }

		public double StateTime { get; set; }

		public double State { get; set; }

		public int TargetModule { get; set; }

		public Coordinates OriginalRotation { get; set; }

		public Coordinates FinalRotation { get; set; }

		public int Size { get; set; }

		public bool Intruders { get; set; }

		public Coordinates Velocity { get; set; }

		public string VisitorEventName { get; set; }

		public int ShipType { get; set; }

		public int PendingVisitors { get; set; }

		public int Fee { get; set; }

		public int Prestige { get; set; }
	}
}