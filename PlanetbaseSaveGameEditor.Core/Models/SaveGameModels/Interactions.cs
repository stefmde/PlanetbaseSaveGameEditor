using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "interactions")]
	public class Interactions
	{
		[XmlElement(ElementName = "interaction")]
		public List<Interaction> Interaction { get; set; }
	}
}