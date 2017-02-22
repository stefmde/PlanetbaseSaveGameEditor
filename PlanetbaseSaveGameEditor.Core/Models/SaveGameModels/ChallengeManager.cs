using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "challenge-manager")]
	public class ChallengeManager
	{
		[XmlElement(ElementName = "challenge-id")]
		public ValueAttribute<String> ChallengeId { get; set; }
	}
}