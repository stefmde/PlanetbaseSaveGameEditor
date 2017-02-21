using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "challenge-manager")]
	public class ChallengeManager
	{
		[XmlElement(ElementName = "challenge-id")]
		public ChallengeId ChallengeId { get; set; }
	}
}