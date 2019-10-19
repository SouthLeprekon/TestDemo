namespace Gui.Modules.RegisterTradingEquipment
{
	partial class RegisterTradingEquipmentView
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
			this.providerComboBox = new System.Windows.Forms.ComboBox();
			this.modelComboBox = new System.Windows.Forms.ComboBox();
			this.providerLabel = new System.Windows.Forms.Label();
			this.modelLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.locationLabel = new System.Windows.Forms.Label();
			this.locationComboBox = new System.Windows.Forms.ComboBox();
			this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.amountLabel = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dateLabel = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// providerComboBox
			// 
			this.providerComboBox.DisplayMember = "Name";
			this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.providerComboBox.FormattingEnabled = true;
			this.providerComboBox.Location = new System.Drawing.Point(68, 39);
			this.providerComboBox.Name = "providerComboBox";
			this.providerComboBox.Size = new System.Drawing.Size(229, 21);
			this.providerComboBox.TabIndex = 1;
			this.providerComboBox.ValueMember = "Id";
			// 
			// modelComboBox
			// 
			this.modelComboBox.DisplayMember = "Name";
			this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modelComboBox.FormattingEnabled = true;
			this.modelComboBox.Location = new System.Drawing.Point(67, 12);
			this.modelComboBox.Name = "modelComboBox";
			this.modelComboBox.Size = new System.Drawing.Size(230, 21);
			this.modelComboBox.TabIndex = 0;
			this.modelComboBox.ValueMember = "Id";
			// 
			// providerLabel
			// 
			this.providerLabel.AutoSize = true;
			this.providerLabel.Location = new System.Drawing.Point(13, 43);
			this.providerLabel.Name = "providerLabel";
			this.providerLabel.Size = new System.Drawing.Size(46, 13);
			this.providerLabel.TabIndex = 8;
			this.providerLabel.Text = "Provider";
			// 
			// modelLabel
			// 
			this.modelLabel.AutoSize = true;
			this.modelLabel.Location = new System.Drawing.Point(12, 16);
			this.modelLabel.Name = "modelLabel";
			this.modelLabel.Size = new System.Drawing.Size(36, 13);
			this.modelLabel.TabIndex = 9;
			this.modelLabel.Text = "Model";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(163, 147);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(82, 147);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// locationLabel
			// 
			this.locationLabel.AutoSize = true;
			this.locationLabel.Location = new System.Drawing.Point(13, 70);
			this.locationLabel.Name = "locationLabel";
			this.locationLabel.Size = new System.Drawing.Size(48, 13);
			this.locationLabel.TabIndex = 8;
			this.locationLabel.Text = "Location";
			// 
			// locationComboBox
			// 
			this.locationComboBox.DisplayMember = "Name";
			this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.locationComboBox.FormattingEnabled = true;
			this.locationComboBox.Location = new System.Drawing.Point(68, 66);
			this.locationComboBox.Name = "locationComboBox";
			this.locationComboBox.Size = new System.Drawing.Size(229, 21);
			this.locationComboBox.TabIndex = 2;
			this.locationComboBox.ValueMember = "Id";
			// 
			// amountNumericUpDown
			// 
			this.amountNumericUpDown.Location = new System.Drawing.Point(67, 119);
			this.amountNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.amountNumericUpDown.Name = "amountNumericUpDown";
			this.amountNumericUpDown.Size = new System.Drawing.Size(229, 20);
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
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(68, 93);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(229, 20);
			this.dateTimePicker.TabIndex = 3;
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(14, 97);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(30, 13);
			this.dateLabel.TabIndex = 8;
			this.dateLabel.Text = "Date";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// RegisterTradingEquipmentView
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(320, 179);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.amountNumericUpDown);
			this.Controls.Add(this.locationComboBox);
			this.Controls.Add(this.providerComboBox);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.amountLabel);
			this.Controls.Add(this.locationLabel);
			this.Controls.Add(this.modelComboBox);
			this.Controls.Add(this.providerLabel);
			this.Controls.Add(this.modelLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterTradingEquipmentView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register Trading Equipment";
			((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox providerComboBox;
		private System.Windows.Forms.ComboBox modelComboBox;
		private System.Windows.Forms.Label providerLabel;
		private System.Windows.Forms.Label modelLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label locationLabel;
		private System.Windows.Forms.ComboBox locationComboBox;
		private System.Windows.Forms.NumericUpDown amountNumericUpDown;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}