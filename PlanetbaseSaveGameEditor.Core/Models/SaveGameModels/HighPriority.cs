using System;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "high-priority")]
	public class HighPriority
	{
		private string _stringValue = "False";
		[XmlAttribute(AttributeName = "value")]
		public string StringValue
		{
			get { return _stringValue; }
			set
			{
				_stringValue = value.Equals("true", StringComparison.OrdinalIgnoreCase) ? "True" : "False";
			}
		}

		[XmlIgnore]
		public bool Value
		{
			get
			{
				return StringValue == "True";
			}
			set
			{
				StringValue = value ? "True" : "False";
			}
		}
	}
}