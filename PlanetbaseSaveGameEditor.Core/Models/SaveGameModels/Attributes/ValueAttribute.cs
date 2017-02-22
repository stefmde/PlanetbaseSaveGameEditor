using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes
{
	public class ValueAttribute<T>
	{
		[XmlAttribute(AttributeName = "value")]
		public T Value { get; set; }
	}

}
