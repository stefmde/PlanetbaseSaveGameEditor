using System;
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
using PlanetbaseSaveGameEditor.Core.Worker;

namespace PlanetbaseSaveGameEditor.TestWinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{

		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			textBoxLog.AppendText("Try to list SaveGames..." + Environment.NewLine);
			if (!string.IsNullOrEmpty(textBoxSaveGameRootPath.Text) && Directory.Exists(textBoxSaveGameRootPath.Text))
			{
				List<SaveGameFile> saveGameFiles = SaveGameManager.GetSaveGameFiles(textBoxSaveGameRootPath.Text);
				coBxSaveGames.Items.AddRange(saveGameFiles.ToArray());
				coBxSaveGames.SelectedItem = saveGameFiles.First();
				textBoxLog.AppendText(saveGameFiles.Count + " SaveGames listed." + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("Directory doesnt exist or no path given." + Environment.NewLine);
			}
		}

		private void buttonPatchAll_Click(object sender, EventArgs e)
		{
			if (coBxSaveGames.SelectedText == String.Empty)
			{
				textBoxLog.AppendText("No file selected." + Environment.NewLine + Environment.NewLine);
			}
			else
			{
				textBoxLog.AppendText("Getting file..." + Environment.NewLine);
				SaveGameFile selectedSaveGameFile = (SaveGameFile)coBxSaveGames.SelectedItem;

				textBoxLog.AppendText("Reading file..." + Environment.NewLine);
				string fileContent = File.ReadAllText(selectedSaveGameFile.FullName);

				textBoxLog.AppendText("Deserializing..." + Environment.NewLine);
				SaveGame saveGame = SaveGameManager.DeSerializeFromXml<SaveGame>(fileContent).FillAllCollectors().HealAllCharacters().DoAllConstructions();

				textBoxLog.AppendText("Patching..." + Environment.NewLine);
				saveGame = saveGame.FillAllCollectors().HealAllCharacters().DoAllConstructions();

				textBoxLog.AppendText("Serializing..." + Environment.NewLine);
				string saveGameXml = SaveGameManager.SerializeToXml(saveGame);

				textBoxLog.AppendText("Writing file content..." + Environment.NewLine);
				File.WriteAllText(textBoxSaveGameRootPath.Text, saveGameXml);

				textBoxLog.AppendText("Done." + Environment.NewLine + Environment.NewLine);
			}
		}


	}
}
