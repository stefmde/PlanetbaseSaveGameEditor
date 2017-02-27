using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.Enums;

namespace PlanetbaseSaveGameEditor.Models
{
	public class HumanCondition
	{
		public HumanConditionType Type { get; set; }


		public double Time { get; set; }

		public double ConditionTime { get; set; }

		public double ContagionTime { get; set; }
	}
}