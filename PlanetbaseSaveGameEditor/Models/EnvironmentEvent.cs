using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class EnvironmentEvent
	{
		public bool EventInProgress { get; set; }

		public double TimeToNextEvent { get; set; }

		public double Time { get; set; }

		public double EventTime { get; set; }
	}
}