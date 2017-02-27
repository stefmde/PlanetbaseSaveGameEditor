using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Models
{
	public class InmaterialResources
	{
		public string Containername { get; set; }

		public AmountCore Amount { get; set; }
	}
}