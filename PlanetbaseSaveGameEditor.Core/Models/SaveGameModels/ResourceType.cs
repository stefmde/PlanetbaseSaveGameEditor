using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "resource-type")]
	public class ResourceType
	{
		[XmlAttribute(AttributeName = "value")]
		public ResourceTypeType Value { get; set; }
	}

	public enum ResourceTypeType
	{
		Unknown,
		Vegetables,
		Meal,
		Vitromeat,
		MedicalSupplies,
		Bioplastic,
		Ore,
		Spares,
		Metal,
		Semiconductors,
		Coins,



	}
}