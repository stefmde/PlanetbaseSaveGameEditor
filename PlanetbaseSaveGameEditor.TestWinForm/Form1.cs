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

		private void buttonPatchAll_Click(object sender, EventArgs e)
		{
			textBoxLog.AppendText("Reading file content..." + Environment.NewLine);
			string fileContent = File.ReadAllText(textBoxFilePath.Text);

			textBoxLog.AppendText("Deserializing..." + Environment.NewLine);
			SaveGame saveGame = SaveGameManager.DeSerializeFromXml(fileContent).FillAllCollectors().HealAllCharacters().DoAllConstructions();

			textBoxLog.AppendText("Patching..." + Environment.NewLine);
			saveGame = saveGame.FillAllCollectors().HealAllCharacters().DoAllConstructions();

			textBoxLog.AppendText("Serializing..." + Environment.NewLine);
			string saveGameXml = SaveGameManager.SerializeToXml(saveGame);

			textBoxLog.AppendText("Writing file content..." + Environment.NewLine);
			File.WriteAllText(textBoxFilePath.Text, saveGameXml);

			textBoxLog.AppendText("Done." + Environment.NewLine + Environment.NewLine);
		}
	}
}
