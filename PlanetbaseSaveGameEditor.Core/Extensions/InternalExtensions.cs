using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetbaseSaveGameEditor.Core.Extensions
{
	public static class InternalExtensions
	{
		public static int ParseFailsaveInt(this object input, int defaultValue = 0)
		{
			int result = defaultValue;

			string stringValue = input?.ToString();

			if (!string.IsNullOrEmpty(stringValue))
			{
				try
				{
					result = int.Parse(stringValue);
				}
				catch
				{
					//throw;
				}
			}

			return result;
		}
	}
}
