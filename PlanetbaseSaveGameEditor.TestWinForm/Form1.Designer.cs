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
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.coBxSaveGames = new System.Windows.Forms.ComboBox();
			this.buttonLoadFile = new System.Windows.Forms.Button();
			this.groupBoxResources = new System.Windows.Forms.GroupBox();
			this.dataGridViewResources = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewCharacters = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonRefillAllWaterTanks = new System.Windows.Forms.Button();
			this.buttonRefillAllPowerCollectors = new System.Windows.Forms.Button();
			this.buttonRefillAllCollectorTypes = new System.Windows.Forms.Button();
			this.buttonHealAndRepairAllCharacterTypes = new System.Windows.Forms.Button();
			this.buttonRepairAllBots = new System.Windows.Forms.Button();
			this.buttonHealAllColonists = new System.Windows.Forms.Button();
			this.buttonBuildAndRepairAllBuildings = new System.Windows.Forms.Button();
			this.buttonRepairAllBuildings = new System.Windows.Forms.Button();
			this.buttonBuildAllBuildings = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.buttonAddResourcesAndCharacters = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.chbxSaveWithBackup = new System.Windows.Forms.CheckBox();
			this.ColumnCharacterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCharacterIcon = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnCharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCharacterExisting = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCharacterAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnResourcesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnResourcesIcon = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColumnResourcesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnResourcesExisting = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnResourcesAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBoxResources.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxSaveGameRootPath
			// 
			this.textBoxSaveGameRootPath.Location = new System.Drawing.Point(131, 19);
			this.textBoxSaveGameRootPath.Name = "textBoxSaveGameRootPath";
			this.textBoxSaveGameRootPath.Size = new System.Drawing.Size(671, 20);
			this.textBoxSaveGameRootPath.TabIndex = 0;
			this.textBoxSaveGameRootPath.Text = "F:\\Drive\\OneDrive\\Dokumente\\Planetbase\\Saves\\";
			this.textBoxSaveGameRootPath.TextChanged += new System.EventHandler(this.textBoxSaveGameRootPath_TextChanged);
			// 
			// buttonPatchAll
			// 
			this.buttonPatchAll.Location = new System.Drawing.Point(6, 223);
			this.buttonPatchAll.Name = "buttonPatchAll";
			this.buttonPatchAll.Size = new System.Drawing.Size(292, 22);
			this.buttonPatchAll.TabIndex = 1;
			this.buttonPatchAll.Text = "Patch All";
			this.buttonPatchAll.UseVisualStyleBackColor = true;
			this.buttonPatchAll.Click += new System.EventHandler(this.buttonPatchAll_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "SaveGame Root Path:";
			// 
			// textBoxLog
			// 
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Location = new System.Drawing.Point(3, 16);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLog.Size = new System.Drawing.Size(808, 147);
			this.textBoxLog.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Selected SaveGame:";
			// 
			// coBxSaveGames
			// 
			this.coBxSaveGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coBxSaveGames.FormattingEnabled = true;
			this.coBxSaveGames.Location = new System.Drawing.Point(131, 45);
			this.coBxSaveGames.Name = "coBxSaveGames";
			this.coBxSaveGames.Size = new System.Drawing.Size(590, 21);
			this.coBxSaveGames.TabIndex = 6;
			this.coBxSaveGames.SelectedValueChanged += new System.EventHandler(this.coBxSaveGames_SelectedValueChanged);
			// 
			// buttonLoadFile
			// 
			this.buttonLoadFile.Location = new System.Drawing.Point(727, 43);
			this.buttonLoadFile.Name = "buttonLoadFile";
			this.buttonLoadFile.Size = new System.Drawing.Size(75, 22);
			this.buttonLoadFile.TabIndex = 7;
			this.buttonLoadFile.Text = "Load";
			this.buttonLoadFile.UseVisualStyleBackColor = true;
			this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
			// 
			// groupBoxResources
			// 
			this.groupBoxResources.Controls.Add(this.dataGridViewResources);
			this.groupBoxResources.Location = new System.Drawing.Point(12, 97);
			this.groupBoxResources.Name = "groupBoxResources";
			this.groupBoxResources.Size = new System.Drawing.Size(246, 351);
			this.groupBoxResources.TabIndex = 8;
			this.groupBoxResources.TabStop = false;
			this.groupBoxResources.Text = "Resources";
			// 
			// dataGridViewResources
			// 
			this.dataGridViewResources.AllowUserToAddRows = false;
			this.dataGridViewResources.AllowUserToDeleteRows = false;
			this.dataGridViewResources.AllowUserToResizeColumns = false;
			this.dataGridViewResources.AllowUserToResizeRows = false;
			this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResourcesType,
            this.ColumnResourcesIcon,
            this.ColumnResourcesName,
            this.ColumnResourcesExisting,
            this.ColumnResourcesAdd});
			this.dataGridViewResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewResources.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewResources.MultiSelect = false;
			this.dataGridViewResources.Name = "dataGridViewResources";
			this.dataGridViewResources.RowHeadersVisible = false;
			this.dataGridViewResources.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewResources.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewResources.ShowEditingIcon = false;
			this.dataGridViewResources.Size = new System.Drawing.Size(240, 332);
			this.dataGridViewResources.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewCharacters);
			this.groupBox1.Location = new System.Drawing.Point(264, 97);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 241);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Characters";
			// 
			// dataGridViewCharacters
			// 
			this.dataGridViewCharacters.AllowUserToAddRows = false;
			this.dataGridViewCharacters.AllowUserToDeleteRows = false;
			this.dataGridViewCharacters.AllowUserToResizeColumns = false;
			this.dataGridViewCharacters.AllowUserToResizeRows = false;
			this.dataGridViewCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCharacterType,
            this.ColumnCharacterIcon,
            this.ColumnCharacterName,
            this.ColumnCharacterExisting,
            this.ColumnCharacterAdd});
			this.dataGridViewCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewCharacters.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewCharacters.MultiSelect = false;
			this.dataGridViewCharacters.Name = "dataGridViewCharacters";
			this.dataGridViewCharacters.RowHeadersVisible = false;
			this.dataGridViewCharacters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewCharacters.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCharacters.ShowEditingIcon = false;
			this.dataGridViewCharacters.Size = new System.Drawing.Size(240, 222);
			this.dataGridViewCharacters.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chbxSaveWithBackup);
			this.groupBox2.Controls.Add(this.buttonSave);
			this.groupBox2.Controls.Add(this.buttonAddResourcesAndCharacters);
			this.groupBox2.Controls.Add(this.buttonBuildAndRepairAllBuildings);
			this.groupBox2.Controls.Add(this.buttonPatchAll);
			this.groupBox2.Controls.Add(this.buttonRepairAllBuildings);
			this.groupBox2.Controls.Add(this.buttonBuildAllBuildings);
			this.groupBox2.Controls.Add(this.buttonHealAndRepairAllCharacterTypes);
			this.groupBox2.Controls.Add(this.buttonRepairAllBots);
			this.groupBox2.Controls.Add(this.buttonHealAllColonists);
			this.groupBox2.Controls.Add(this.buttonRefillAllCollectorTypes);
			this.groupBox2.Controls.Add(this.buttonRefillAllPowerCollectors);
			this.groupBox2.Controls.Add(this.buttonRefillAllWaterTanks);
			this.groupBox2.Location = new System.Drawing.Point(516, 97);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(313, 351);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			// 
			// buttonRefillAllWaterTanks
			// 
			this.buttonRefillAllWaterTanks.Location = new System.Drawing.Point(6, 19);
			this.buttonRefillAllWaterTanks.Name = "buttonRefillAllWaterTanks";
			this.buttonRefillAllWaterTanks.Size = new System.Drawing.Size(143, 22);
			this.buttonRefillAllWaterTanks.TabIndex = 11;
			this.buttonRefillAllWaterTanks.Text = "Refill All Water Tanks";
			this.buttonRefillAllWaterTanks.UseVisualStyleBackColor = true;
			this.buttonRefillAllWaterTanks.Click += new System.EventHandler(this.buttonRefillAllWaterTanks_Click);
			// 
			// buttonRefillAllPowerCollectors
			// 
			this.buttonRefillAllPowerCollectors.Location = new System.Drawing.Point(155, 19);
			this.buttonRefillAllPowerCollectors.Name = "buttonRefillAllPowerCollectors";
			this.buttonRefillAllPowerCollectors.Size = new System.Drawing.Size(143, 22);
			this.buttonRefillAllPowerCollectors.TabIndex = 12;
			this.buttonRefillAllPowerCollectors.Text = "Refill All Power Collectors";
			this.buttonRefillAllPowerCollectors.UseVisualStyleBackColor = true;
			this.buttonRefillAllPowerCollectors.Click += new System.EventHandler(this.buttonRefillAllPowerCollectors_Click);
			// 
			// buttonRefillAllCollectorTypes
			// 
			this.buttonRefillAllCollectorTypes.Location = new System.Drawing.Point(6, 47);
			this.buttonRefillAllCollectorTypes.Name = "buttonRefillAllCollectorTypes";
			this.buttonRefillAllCollectorTypes.Size = new System.Drawing.Size(292, 22);
			this.buttonRefillAllCollectorTypes.TabIndex = 13;
			this.buttonRefillAllCollectorTypes.Text = "Refill All Collector Types";
			this.buttonRefillAllCollectorTypes.UseVisualStyleBackColor = true;
			this.buttonRefillAllCollectorTypes.Click += new System.EventHandler(this.buttonRefillAllCollectorTypes_Click);
			// 
			// buttonHealAndRepairAllCharacterTypes
			// 
			this.buttonHealAndRepairAllCharacterTypes.Location = new System.Drawing.Point(6, 116);
			this.buttonHealAndRepairAllCharacterTypes.Name = "buttonHealAndRepairAllCharacterTypes";
			this.buttonHealAndRepairAllCharacterTypes.Size = new System.Drawing.Size(292, 22);
			this.buttonHealAndRepairAllCharacterTypes.TabIndex = 16;
			this.buttonHealAndRepairAllCharacterTypes.Text = "Heal And Repair All Character Types";
			this.buttonHealAndRepairAllCharacterTypes.UseVisualStyleBackColor = true;
			this.buttonHealAndRepairAllCharacterTypes.Click += new System.EventHandler(this.buttonHealAndRepairAllCharacterTypes_Click);
			// 
			// buttonRepairAllBots
			// 
			this.buttonRepairAllBots.Location = new System.Drawing.Point(155, 88);
			this.buttonRepairAllBots.Name = "buttonRepairAllBots";
			this.buttonRepairAllBots.Size = new System.Drawing.Size(143, 22);
			this.buttonRepairAllBots.TabIndex = 15;
			this.buttonRepairAllBots.Text = "Repair All Bots";
			this.buttonRepairAllBots.UseVisualStyleBackColor = true;
			this.buttonRepairAllBots.Click += new System.EventHandler(this.buttonRepairAllBots_Click);
			// 
			// buttonHealAllColonists
			// 
			this.buttonHealAllColonists.Location = new System.Drawing.Point(6, 88);
			this.buttonHealAllColonists.Name = "buttonHealAllColonists";
			this.buttonHealAllColonists.Size = new System.Drawing.Size(143, 22);
			this.buttonHealAllColonists.TabIndex = 14;
			this.buttonHealAllColonists.Text = "Heal All Colonists";
			this.buttonHealAllColonists.UseVisualStyleBackColor = true;
			this.buttonHealAllColonists.Click += new System.EventHandler(this.buttonHealAllColonists_Click);
			// 
			// buttonBuildAndRepairAllBuildings
			// 
			this.buttonBuildAndRepairAllBuildings.Location = new System.Drawing.Point(6, 184);
			this.buttonBuildAndRepairAllBuildings.Name = "buttonBuildAndRepairAllBuildings";
			this.buttonBuildAndRepairAllBuildings.Size = new System.Drawing.Size(292, 22);
			this.buttonBuildAndRepairAllBuildings.TabIndex = 19;
			this.buttonBuildAndRepairAllBuildings.Text = "Build And Repair All Buildings";
			this.buttonBuildAndRepairAllBuildings.UseVisualStyleBackColor = true;
			this.buttonBuildAndRepairAllBuildings.Click += new System.EventHandler(this.buttonBuildAndRepairAllBuildings_Click);
			// 
			// buttonRepairAllBuildings
			// 
			this.buttonRepairAllBuildings.Location = new System.Drawing.Point(155, 156);
			this.buttonRepairAllBuildings.Name = "buttonRepairAllBuildings";
			this.buttonRepairAllBuildings.Size = new System.Drawing.Size(143, 22);
			this.buttonRepairAllBuildings.TabIndex = 18;
			this.buttonRepairAllBuildings.Text = "Repair All Buildings";
			this.buttonRepairAllBuildings.UseVisualStyleBackColor = true;
			this.buttonRepairAllBuildings.Click += new System.EventHandler(this.buttonRepairAllBuildings_Click);
			// 
			// buttonBuildAllBuildings
			// 
			this.buttonBuildAllBuildings.Location = new System.Drawing.Point(6, 156);
			this.buttonBuildAllBuildings.Name = "buttonBuildAllBuildings";
			this.buttonBuildAllBuildings.Size = new System.Drawing.Size(143, 22);
			this.buttonBuildAllBuildings.TabIndex = 17;
			this.buttonBuildAllBuildings.Text = "Build All Buildings";
			this.buttonBuildAllBuildings.UseVisualStyleBackColor = true;
			this.buttonBuildAllBuildings.Click += new System.EventHandler(this.buttonBuildAllBuildings_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBoxLog);
			this.groupBox3.Location = new System.Drawing.Point(15, 454);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(814, 166);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Log";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxSaveGameRootPath);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.coBxSaveGames);
			this.groupBox4.Controls.Add(this.buttonLoadFile);
			this.groupBox4.Location = new System.Drawing.Point(12, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(814, 79);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Select SaveGame";
			// 
			// buttonAddResourcesAndCharacters
			// 
			this.buttonAddResourcesAndCharacters.Location = new System.Drawing.Point(6, 251);
			this.buttonAddResourcesAndCharacters.Name = "buttonAddResourcesAndCharacters";
			this.buttonAddResourcesAndCharacters.Size = new System.Drawing.Size(292, 22);
			this.buttonAddResourcesAndCharacters.TabIndex = 20;
			this.buttonAddResourcesAndCharacters.Text = "Add Resources And Characters";
			this.buttonAddResourcesAndCharacters.UseVisualStyleBackColor = true;
			this.buttonAddResourcesAndCharacters.Click += new System.EventHandler(this.buttonAddResourcesAndCharacters_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(6, 291);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(292, 22);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Save SaveGame";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// chbxSaveWithBackup
			// 
			this.chbxSaveWithBackup.AutoSize = true;
			this.chbxSaveWithBackup.Checked = true;
			this.chbxSaveWithBackup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbxSaveWithBackup.Location = new System.Drawing.Point(6, 319);
			this.chbxSaveWithBackup.Name = "chbxSaveWithBackup";
			this.chbxSaveWithBackup.Size = new System.Drawing.Size(172, 17);
			this.chbxSaveWithBackup.TabIndex = 22;
			this.chbxSaveWithBackup.Text = "Save SaveGame With Backup";
			this.chbxSaveWithBackup.UseVisualStyleBackColor = true;
			// 
			// ColumnCharacterType
			// 
			this.ColumnCharacterType.HeaderText = "Type";
			this.ColumnCharacterType.Name = "ColumnCharacterType";
			this.ColumnCharacterType.Visible = false;
			// 
			// ColumnCharacterIcon
			// 
			this.ColumnCharacterIcon.HeaderText = "Icon";
			this.ColumnCharacterIcon.Name = "ColumnCharacterIcon";
			this.ColumnCharacterIcon.Width = 35;
			// 
			// ColumnCharacterName
			// 
			this.ColumnCharacterName.HeaderText = "Name";
			this.ColumnCharacterName.Name = "ColumnCharacterName";
			// 
			// ColumnCharacterExisting
			// 
			this.ColumnCharacterExisting.HeaderText = "Existing";
			this.ColumnCharacterExisting.Name = "ColumnCharacterExisting";
			this.ColumnCharacterExisting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnCharacterExisting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnCharacterExisting.Width = 50;
			// 
			// ColumnCharacterAdd
			// 
			this.ColumnCharacterAdd.HeaderText = "Add";
			this.ColumnCharacterAdd.Name = "ColumnCharacterAdd";
			this.ColumnCharacterAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnCharacterAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnCharacterAdd.Width = 50;
			// 
			// ColumnResourcesType
			// 
			this.ColumnResourcesType.HeaderText = "Type";
			this.ColumnResourcesType.Name = "ColumnResourcesType";
			this.ColumnResourcesType.ReadOnly = true;
			this.ColumnResourcesType.Visible = false;
			// 
			// ColumnResourcesIcon
			// 
			this.ColumnResourcesIcon.HeaderText = "Icon";
			this.ColumnResourcesIcon.Name = "ColumnResourcesIcon";
			this.ColumnResourcesIcon.Width = 35;
			// 
			// ColumnResourcesName
			// 
			this.ColumnResourcesName.HeaderText = "Name";
			this.ColumnResourcesName.Name = "ColumnResourcesName";
			// 
			// ColumnResourcesExisting
			// 
			this.ColumnResourcesExisting.HeaderText = "Existing";
			this.ColumnResourcesExisting.Name = "ColumnResourcesExisting";
			this.ColumnResourcesExisting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnResourcesExisting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnResourcesExisting.Width = 50;
			// 
			// ColumnResourcesAdd
			// 
			this.ColumnResourcesAdd.HeaderText = "Add";
			this.ColumnResourcesAdd.Name = "ColumnResourcesAdd";
			this.ColumnResourcesAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnResourcesAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnResourcesAdd.Width = 50;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 634);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxResources);
			this.Name = "Form1";
			this.Text = "Planetbase SaveGame Editor";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.groupBoxResources.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharacters)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSaveGameRootPath;
		private System.Windows.Forms.Button buttonPatchAll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox coBxSaveGames;
		private System.Windows.Forms.Button buttonLoadFile;
		private System.Windows.Forms.GroupBox groupBoxResources;
		private System.Windows.Forms.DataGridView dataGridViewResources;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridViewCharacters;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonRefillAllWaterTanks;
		private System.Windows.Forms.Button buttonRefillAllCollectorTypes;
		private System.Windows.Forms.Button buttonRefillAllPowerCollectors;
		private System.Windows.Forms.Button buttonHealAndRepairAllCharacterTypes;
		private System.Windows.Forms.Button buttonRepairAllBots;
		private System.Windows.Forms.Button buttonHealAllColonists;
		private System.Windows.Forms.Button buttonBuildAndRepairAllBuildings;
		private System.Windows.Forms.Button buttonRepairAllBuildings;
		private System.Windows.Forms.Button buttonBuildAllBuildings;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox chbxSaveWithBackup;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonAddResourcesAndCharacters;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourcesType;
		private System.Windows.Forms.DataGridViewImageColumn ColumnResourcesIcon;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourcesName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourcesExisting;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResourcesAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCharacterType;
		private System.Windows.Forms.DataGridViewImageColumn ColumnCharacterIcon;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCharacterName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCharacterExisting;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCharacterAdd;
	}
}

