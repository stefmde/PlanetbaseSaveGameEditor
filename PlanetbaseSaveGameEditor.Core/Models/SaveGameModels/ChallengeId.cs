using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "challenge-id")]
	public class ChallengeId
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}