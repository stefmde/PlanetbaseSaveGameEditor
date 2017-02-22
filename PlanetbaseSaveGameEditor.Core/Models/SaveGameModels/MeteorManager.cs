using System;
using System.Xml.Serialization;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.Attributes;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "meteor-manager")]
	public class MeteorManager
	{
		[XmlElement(ElementName = "seeds")]
		public ValueAttribute<String> MeteorSeeds { get; set; }
	}
}