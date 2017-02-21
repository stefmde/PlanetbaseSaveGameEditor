using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "module-type")]
	public class ModuleType
	{
		[XmlAttribute(AttributeName = "value")]
		public ModuleTypeType Value { get; set; }
	}

	public enum ModuleTypeType
	{
		Unknown,
		ModuleTypeDorm,
		ModuleTypeLab,
		ModuleTypeOxygenGenerator,
		ModuleTypeAirlock,
		ModuleTypeSolarPanel,
		ModuleTypeWindTurbine,
		ModuleTypePowerCollector,
		ModuleTypeWaterExtractor,
		ModuleTypeWaterTank,
		ModuleTypeBioDome,
		ModuleTypeCanteen,
		ModuleTypeMine,
		ModuleTypeLandingPad,
		ModuleTypeSickBay,
		ModuleTypeProcessingPlant,
		ModuleTypeStorage,
		ModuleTypeControlCenter,
		ModuleTypeFactory,
		ModuleTypeBar,
		ModuleTypeRoboticsFacility,
		ModuleTypeCabin,
		ModuleTypeMultiDome,
		ModuleTypeRadioAntenna,
		ModuleTypeTelescope,
		ModuleTypePyramid,
		ModuleTypeStarport,
		ModuleTypeSignpost,
		ModuleTypeAntiMeteorLaser,
		ModuleTypeMonolith
	}
}