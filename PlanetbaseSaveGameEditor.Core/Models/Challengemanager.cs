using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models
{
	[XmlRoot(ElementName = "challenge-manager")]
	public class ChallengeManager
	{
		[XmlElement(ElementName = "challenge-id")]
		public ChallengeId Challengeid { get; set; }
	}
}