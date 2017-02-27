using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanetbaseSaveGameEditor.Core.Extensions;
using PlanetbaseSaveGameEditor.Core.Models;
using PlanetbaseSaveGameEditor.Core.Models.Enums;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels;
using PlanetbaseSaveGameEditor.Core.Models.SaveGameModels.CharacterModels;
using PlanetbaseSaveGameEditor.Core.Worker;
using Environment = System.Environment;
using Resources = PlanetbaseSaveGameEditor.TestWinForm.Properties.Resources;

namespace PlanetbaseSaveGameEditor.TestWinForm
{
	public partial class Form1 : Form
	{
		private SaveGameFile _selectedSaveGame;
		private SaveGameCore _loadedSaveGame;

		public Form1()
		{
			InitializeComponent();
		}

		#region UIEvents

		private void Form1_Shown(object sender, EventArgs e)
		{

		}
		private void textBoxSaveGameRootPath_TextChanged(object sender, EventArgs e)
		{
			UpdateFileList();
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			UpdateFileList();
		}

		private void coBxSaveGames_SelectedValueChanged(object sender, EventArgs e)
		{

		}

		private void buttonPatchAll_Click(object sender, EventArgs e)
		{
			if (coBxSaveGames.SelectedText == String.Empty)
			{
				textBoxLog.AppendText("No file selected." + Environment.NewLine + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("Patching..." + Environment.NewLine);
				_loadedSaveGame = _loadedSaveGame.FillAllCollectors().HealAllCharacters().DoAllConstructions();
			}
		}

		private void buttonLoadFile_Click(object sender, EventArgs e)
		{
			LoadFile();
		}



		private void buttonSave_Click(object sender, EventArgs e)
		{
			textBoxLog.AppendText("Serializing..." + Environment.NewLine);
			string saveGameXml = FileManager.SerializeToXml(_loadedSaveGame);

			textBoxLog.AppendText("Writing file content..." + Environment.NewLine);
			File.WriteAllText(_selectedSaveGame.FullName, saveGameXml);

			textBoxLog.AppendText("Done." + Environment.NewLine);
			textBoxLog.AppendText("Reloading file..." + Environment.NewLine + Environment.NewLine);

			LoadFile();
		}

		private void buttonRefillAllWaterTanks_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.FillAllWatterTanks();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonRefillAllPowerCollectors_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.FillAllPowerCollectors();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonRefillAllCollectorTypes_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.FillAllCollectors();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonHealAllColonists_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.HealAllColonists();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonRepairAllBots_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.RepairAllBots();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonHealAndRepairAllCharacterTypes_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.HealAllCharacters();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonBuildAllBuildings_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.BuildAllConstructions();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonRepairAllBuildings_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.RepairAllConstructions();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonBuildAndRepairAllBuildings_Click(object sender, EventArgs e)
		{
			if (_loadedSaveGame != null)
			{
				_loadedSaveGame = _loadedSaveGame.DoAllConstructions();
				textBoxLog.AppendText("Done." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("No SaveGame selected." + Environment.NewLine);
			}
		}

		private void buttonAddResourcesAndCharacters_Click(object sender, EventArgs e)
		{
			// 0 + 4
			Dictionary<string, int> dictionary = new Dictionary<string, int>();

			foreach (DataGridViewRow row in dataGridViewResources.Rows)
			{
				int value = row.Cells[4].Value.ParseFailsaveInt();
				if (value > 0)
				{
					dictionary.Add(row.Cells[0].Value.ToString(), value);
					string stringType = row.Cells[0].Value.ToString().Replace("Resource.", "");
					_loadedSaveGame.AddResource((ResourceType)Enum.Parse(typeof(ResourceType), stringType), value);
					row.Cells[4].Value = String.Empty;
					row.Cells[3].Value = row.Cells[3].Value.ParseFailsaveInt() + value;
				}
			}

			foreach (DataGridViewRow row in dataGridViewCharacters.Rows)
			{
				int value = row.Cells[4].Value.ParseFailsaveInt();
				if (value > 0)
				{
					dictionary.Add(row.Cells[0].Value.ToString(), value);
				}
			}
		}

		#endregion



		#region LocalHelpers

		private void LoadFile()
		{
			textBoxLog.AppendText("Updating selected file..." + Environment.NewLine);
			_selectedSaveGame = (SaveGameFile)coBxSaveGames.SelectedItem;
			textBoxLog.AppendText("Loaded file: " + _selectedSaveGame.FullName + Environment.NewLine);


			textBoxLog.AppendText("Reading file..." + Environment.NewLine);
			string fileContent = File.ReadAllText(_selectedSaveGame.FullName);

			textBoxLog.AppendText("Deserializing..." + Environment.NewLine);
			_loadedSaveGame = FileManager.DeSerializeFromXml<SaveGameCore>(fileContent).FillAllCollectors().HealAllCharacters().DoAllConstructions();

			textBoxLog.AppendText("Computing data..." + Environment.NewLine);
			UpdateResourceDatagrid();
			UpdateCharacterDatagrid();
			textBoxLog.AppendText("Done." + Environment.NewLine);
		}


		private void UpdateFileList()
		{
			textBoxLog.AppendText("Try to list SaveGames..." + Environment.NewLine);
			if (!string.IsNullOrEmpty(textBoxSaveGameRootPath.Text) && Directory.Exists(textBoxSaveGameRootPath.Text))
			{
				List<SaveGameFile> saveGameFiles = FileManager.GetSaveGameFiles(textBoxSaveGameRootPath.Text);
				coBxSaveGames.Items.AddRange(saveGameFiles.ToArray());
				coBxSaveGames.SelectedItem = saveGameFiles.First();
				textBoxLog.AppendText(saveGameFiles.Count + " SaveGames listed." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("Directory doesnt exist or no path given." + Environment.NewLine);
			}
		}


		// ### Resource DataGrid
		// ####################################################################################################
		private void UpdateResourceDatagrid()
		{
			dataGridViewResources.Rows.Clear();
			foreach (ResourceType resource in Enum.GetValues(typeof(ResourceType)))
			{
				if (resource != ResourceType.Unknown)
				{
					dataGridViewResources.Rows.Add(GetDatagridResourceRowByName(resource, 26));
				}
			}
		}

		private object[] GetDatagridResourceRowByName(ResourceType type, int size)
		{
			List<object> row = new List<object>();
			string name = type.ToString();

			row.Add("Resource." + type);
			row.Add(Resources.ResourceManager.GetObject("Resource_" + name + "_x" + size));
			row.Add(name);
			row.Add(_loadedSaveGame.Resources.Resource.Count(x => x.Type == type));

			return row.ToArray();
		}



		// ### Character DataGrid
		// ####################################################################################################

		private void UpdateCharacterDatagrid()
		{
			dataGridViewCharacters.Rows.Clear();
			foreach (BotSpecializationType character in Enum.GetValues(typeof(BotSpecializationType)))
			{
				if (character != BotSpecializationType.Unknown)
				{
					dataGridViewCharacters.Rows.Add(GetDatagridBotCharacterRowByName(character, 26));
				}
			}

			foreach (ColonistSpecializationType character in Enum.GetValues(typeof(ColonistSpecializationType)))
			{
				if (character != ColonistSpecializationType.Unknown)
				{
					dataGridViewCharacters.Rows.Add(GetDatagridColonistCharacterRowByName(character, 26));
				}
			}
		}
		private object[] GetDatagridBotCharacterRowByName(BotSpecializationType type, int size)
		{
			List<object> row = new List<object>();
			string name = type.ToString();

			row.Add("Character.Bot." + type);
			row.Add(Resources.ResourceManager.GetObject("Character_Bot_" + name + "_x" + size));
			row.Add(name);
			row.Add(_loadedSaveGame.Characters.Where(x => x.CharacterType == CharacterType.Bot).Cast<BotCharacter>().Count(x => x.Specialization.Value == type));

			return row.ToArray();
		}
		private object[] GetDatagridColonistCharacterRowByName(ColonistSpecializationType type, int size)
		{
			List<object> row = new List<object>();
			string name = type.ToString();

			row.Add("Character.Colonist." + type);
			row.Add(Resources.ResourceManager.GetObject("Character_Colonist_" + name + "_x" + size));
			row.Add(name);
			row.Add(_loadedSaveGame.Characters.Where(x => x.CharacterType == CharacterType.Colonist || x.CharacterType == CharacterType.Guest).Cast<ColonistCharacter>().Count(x => x.Specialization.Value == type));

			return row.ToArray();
		}


		#endregion


	}
}
