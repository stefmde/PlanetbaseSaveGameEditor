namespace PlanetbaseSaveGameEditor.TestWinForm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxSaveGameRootPath = new System.Windows.Forms.TextBox();
			this.buttonPatchAll = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.coBxSaveGames = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBoxSaveGameRootPath
			// 
			this.textBoxSaveGameRootPath.Location = new System.Drawing.Point(132, 24);
			this.textBoxSaveGameRootPath.Name = "textBoxSaveGameRootPath";
			this.textBoxSaveGameRootPath.Size = new System.Drawing.Size(414, 20);
			this.textBoxSaveGameRootPath.TabIndex = 0;
			this.textBoxSaveGameRootPath.Text = "F:\\Drive\\OneDrive\\Dokumente\\Planetbase\\Saves\\";
			// 
			// buttonPatchAll
			// 
			this.buttonPatchAll.Location = new System.Drawing.Point(552, 22);
			this.buttonPatchAll.Name = "buttonPatchAll";
			this.buttonPatchAll.Size = new System.Drawing.Size(75, 49);
			this.buttonPatchAll.TabIndex = 1;
			this.buttonPatchAll.Text = "Patch";
			this.buttonPatchAll.UseVisualStyleBackColor = true;
			this.buttonPatchAll.Click += new System.EventHandler(this.buttonPatchAll_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "SaveGame Root Path:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "SaveGame Path:";
			// 
			// textBoxLog
			// 
			this.textBoxLog.Location = new System.Drawing.Point(132, 77);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.Size = new System.Drawing.Size(495, 140);
			this.textBoxLog.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Selected SaveGame:";
			// 
			// coBxSaveGames
			// 
			this.coBxSaveGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coBxSaveGames.FormattingEnabled = true;
			this.coBxSaveGames.Location = new System.Drawing.Point(132, 50);
			this.coBxSaveGames.Name = "coBxSaveGames";
			this.coBxSaveGames.Size = new System.Drawing.Size(414, 21);
			this.coBxSaveGames.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 234);
			this.Controls.Add(this.coBxSaveGames);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPatchAll);
			this.Controls.Add(this.textBoxSaveGameRootPath);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSaveGameRootPath;
		private System.Windows.Forms.Button buttonPatchAll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox coBxSaveGames;
	}
}

