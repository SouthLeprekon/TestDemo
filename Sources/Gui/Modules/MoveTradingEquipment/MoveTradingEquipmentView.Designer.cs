namespace Gui.Modules.MoveTradingEquipment
{
	partial class MoveTradingEquipmentView
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
			this.components = new System.ComponentModel.Container();
			this.destinationComboBox = new System.Windows.Forms.ComboBox();
			this.equipmentComboBox = new System.Windows.Forms.ComboBox();
			this.destinationLabel = new System.Windows.Forms.Label();
			this.equipmentLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.amountLabel = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.sourceLabel = new System.Windows.Forms.Label();
			this.sourceComboBox = new System.Windows.Forms.ComboBox();
			this.availableLabel = new System.Windows.Forms.Label();
			this.availableNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.availableNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// destinationComboBox
			// 
			this.destinationComboBox.DisplayMember = "Name";
			this.destinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.destinationComboBox.FormattingEnabled = true;
			this.destinationComboBox.Location = new System.Drawing.Point(78, 66);
			this.destinationComboBox.Name = "destinationComboBox";
			this.destinationComboBox.Size = new System.Drawing.Size(322, 21);
			this.destinationComboBox.TabIndex = 2;
			this.destinationComboBox.ValueMember = "Id";
			// 
			// equipmentComboBox
			// 
			this.equipmentComboBox.DisplayMember = "Description";
			this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.equipmentComboBox.FormattingEnabled = true;
			this.equipmentComboBox.Location = new System.Drawing.Point(78, 12);
			this.equipmentComboBox.Name = "equipmentComboBox";
			this.equipmentComboBox.Size = new System.Drawing.Size(322, 21);
			this.equipmentComboBox.TabIndex = 0;
			this.equipmentComboBox.ValueMember = "Id";
			this.equipmentComboBox.TextChanged += new System.EventHandler(this.OnEquipmentComboBoxTextChanged);
			// 
			// destinationLabel
			// 
			this.destinationLabel.AutoSize = true;
			this.destinationLabel.Location = new System.Drawing.Point(13, 70);
			this.destinationLabel.Name = "destinationLabel";
			this.destinationLabel.Size = new System.Drawing.Size(60, 13);
			this.destinationLabel.TabIndex = 8;
			this.destinationLabel.Text = "Destination";
			// 
			// equipmentLabel
			// 
			this.equipmentLabel.AutoSize = true;
			this.equipmentLabel.Location = new System.Drawing.Point(12, 16);
			this.equipmentLabel.Name = "equipmentLabel";
			this.equipmentLabel.Size = new System.Drawing.Size(57, 13);
			this.equipmentLabel.TabIndex = 9;
			this.equipmentLabel.Text = "Equipment";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(218, 147);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(137, 147);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// amountNumericUpDown
			// 
			this.amountNumericUpDown.Location = new System.Drawing.Point(78, 119);
			this.amountNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.amountNumericUpDown.Name = "amountNumericUpDown";
			this.amountNumericUpDown.Size = new System.Drawing.Size(322, 20);
			this.amountNumericUpDown.TabIndex = 4;
			this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// amountLabel
			// 
			this.amountLabel.AutoSize = true;
			this.amountLabel.Location = new System.Drawing.Point(13, 123);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(43, 13);
			this.amountLabel.TabIndex = 8;
			this.amountLabel.Text = "Amount";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// sourceLabel
			// 
			this.sourceLabel.AutoSize = true;
			this.sourceLabel.Location = new System.Drawing.Point(13, 43);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(41, 13);
			this.sourceLabel.TabIndex = 8;
			this.sourceLabel.Text = "Source";
			// 
			// sourceComboBox
			// 
			this.sourceComboBox.DisplayMember = "Name";
			this.sourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sourceComboBox.Enabled = false;
			this.sourceComboBox.FormattingEnabled = true;
			this.sourceComboBox.Location = new System.Drawing.Point(78, 39);
			this.sourceComboBox.Name = "sourceComboBox";
			this.sourceComboBox.Size = new System.Drawing.Size(322, 21);
			this.sourceComboBox.TabIndex = 1;
			this.sourceComboBox.ValueMember = "Id";
			// 
			// availableLabel
			// 
			this.availableLabel.AutoSize = true;
			this.availableLabel.Location = new System.Drawing.Point(14, 97);
			this.availableLabel.Name = "availableLabel";
			this.availableLabel.Size = new System.Drawing.Size(50, 13);
			this.availableLabel.TabIndex = 8;
			this.availableLabel.Text = "Available";
			// 
			// availableNumericUpDown
			// 
			this.availableNumericUpDown.Enabled = false;
			this.availableNumericUpDown.Location = new System.Drawing.Point(78, 93);
			this.availableNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.availableNumericUpDown.Name = "availableNumericUpDown";
			this.availableNumericUpDown.Size = new System.Drawing.Size(322, 20);
			this.availableNumericUpDown.TabIndex = 3;
			this.availableNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// MoveTradingEquipmentView
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(430, 179);
			this.Controls.Add(this.availableNumericUpDown);
			this.Controls.Add(this.amountNumericUpDown);
			this.Controls.Add(this.sourceComboBox);
			this.Controls.Add(this.availableLabel);
			this.Controls.Add(this.destinationComboBox);
			this.Controls.Add(this.amountLabel);
			this.Controls.Add(this.sourceLabel);
			this.Controls.Add(this.equipmentComboBox);
			this.Controls.Add(this.destinationLabel);
			this.Controls.Add(this.equipmentLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MoveTradingEquipmentView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Move Trading Equipment";
			((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.availableNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox destinationComboBox;
		private System.Windows.Forms.ComboBox equipmentComboBox;
		private System.Windows.Forms.Label destinationLabel;
		private System.Windows.Forms.Label equipmentLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.NumericUpDown amountNumericUpDown;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ComboBox sourceComboBox;
		private System.Windows.Forms.Label sourceLabel;
		private System.Windows.Forms.NumericUpDown availableNumericUpDown;
		private System.Windows.Forms.Label availableLabel;
	}
}