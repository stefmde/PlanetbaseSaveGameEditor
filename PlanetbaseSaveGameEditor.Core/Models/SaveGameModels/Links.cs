using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "links")]
	public class Links
	{
		[XmlElement(ElementName = "id")]
		public List<Id> Id { get; set; }
	}
}