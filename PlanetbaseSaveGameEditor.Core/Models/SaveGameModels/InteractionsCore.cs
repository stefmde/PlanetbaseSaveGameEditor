using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "interactions")]
	public class InteractionsCore
	{
		[XmlElement(ElementName = "interaction")]
		public List<InteractionCore> Interaction { get; set; }
	}
}