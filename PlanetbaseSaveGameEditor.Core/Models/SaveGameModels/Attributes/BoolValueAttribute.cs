using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes
{
	public class BoolValueAttribute
	{
		private bool _value;
		[XmlAttribute(AttributeName = "value")]
		public String Value
		{
			get
			{
				return _value ? "True" : "False";
				//return XmlConvert.ToString(_value);
			}
			set
			{
				bool parsedValue;
				if (!Boolean.TryParse(value, out parsedValue))
				{
					parsedValue = XmlConvert.ToBoolean(value);
				}
				_value = parsedValue;
			}
		}
	}
}
