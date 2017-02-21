using System.Xml.Serialization;

namespace PlanetbaseSaveGameEditor.Core.Models.SaveGameModels
{
	[XmlRoot(ElementName = "component-type")]
	public class ComponentType
	{
		[XmlAttribute(AttributeName = "value")]
		public ComponentTypeType Value { get; set; }
	}

	public enum ComponentTypeType
	{
		Unknown,
		MedicinalPad,
		TomatoPad,
		OnionPad,
		MushroomPad,
		PineTree,
		OakTree,
		DrinkingFountain,
		Table,
		VideoScreen,
		MealMaker,
		Bunk,
		SickBayBed,
		MedicalCabinet,
		MetalProcessor,
		BioplasticProcessor,
		TissueSynthesizer,
		Workbench,
		SecurityConsole,
		RadioConsole,
		TelescopeConsole,
		Armory,
		SparesWorkshop,
		SemiconductorFoundry,
		ArmsWorkshop,
		DrinksMachine,
		BarTable,
		BarTableNoChairs,
		BotAutoRepair,
		BotWorkshop,
		Bed,
		Bench,
		Treadmill,
		ExerciseBar,
		DecorativePlant,
		GmOnionPad,
		RadishPad,
		PotatoPad,
		WheatPad,
		RicePad,
		GmTomatoPad,
		LettucePad,
		PeaPad,
		TableSmall,





	}
}