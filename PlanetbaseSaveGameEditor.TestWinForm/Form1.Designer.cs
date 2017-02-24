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
			this.textBoxFilePath = new System.Windows.Forms.TextBox();
			this.buttonPatchAll = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxFilePath
			// 
			this.textBoxFilePath.Location = new System.Drawing.Point(106, 24);
			this.textBoxFilePath.Name = "textBoxFilePath";
			this.textBoxFilePath.Size = new System.Drawing.Size(359, 20);
			this.textBoxFilePath.TabIndex = 0;
			this.textBoxFilePath.Text = "F:\\Drive\\OneDrive\\Dokumente\\Planetbase\\Saves\\quick2.sav";
			// 
			// buttonPatchAll
			// 
			this.buttonPatchAll.Location = new System.Drawing.Point(471, 22);
			this.buttonPatchAll.Name = "buttonPatchAll";
			this.buttonPatchAll.Size = new System.Drawing.Size(75, 23);
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
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "SaveGame Path:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "SaveGame Path:";
			// 
			// textBoxLog
			// 
			this.textBoxLog.Location = new System.Drawing.Point(106, 55);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.Size = new System.Drawing.Size(440, 140);
			this.textBoxLog.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 215);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPatchAll);
			this.Controls.Add(this.textBoxFilePath);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxFilePath;
		private System.Windows.Forms.Button buttonPatchAll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxLog;
	}
}

