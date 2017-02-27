using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class Interaction
	{
		public string Type { get; set; }


		public InteractionCharacter InteractionCharacter { get; set; }

		public Selectable Selectable { get; set; }

		public string InteractionPoint { get; set; }

		public string Stage { get; set; }

		public string StageProgress { get; set; }

		public Coordinates Target { get; set; }
	}
}