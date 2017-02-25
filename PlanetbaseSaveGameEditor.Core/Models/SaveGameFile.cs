using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	public class SaveGameFile
	{
		public string DisplayName => Name + " - " + LastChanged.ToShortDateString() + " " + LastChanged.ToShortTimeString() + " - " + SizeInKb + " Kb";
		public string FullName => RootPath + "\\" + Name;

		public string Name { get; set; }
		public string RootPath { get; set; }
		public DateTime LastChanged { get; set; }
		public long SizeInKb { get; set; }

		public override string ToString()
		{
			return DisplayName;
		}
	}
}
