namespace Gui.Modules.TradingEquipmentModel
{
	partial class TradingEquipmentModelDialog
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
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.producerComboBox = new System.Windows.Forms.ComboBox();
			this.producerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(83, 94);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(164, 94);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(13, 16);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 2;
			this.nameLabel.Text = "Name";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(14, 42);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(31, 13);
			this.typeLabel.TabIndex = 2;
			this.typeLabel.Text = "Type";
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.nameTextBox.Location = new System.Drawing.Point(69, 12);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(229, 20);
			this.nameTextBox.TabIndex = 0;
			// 
			// bindingSource
			// 
			this.bindingSource.DataSource = typeof(Shared.InfoObjects.TradingEquipmentModelInfo);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// typeComboBox
			// 
			this.typeComboBox.DisplayMember = "Name";
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(69, 38);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(229, 21);
			this.typeComboBox.TabIndex = 1;
			this.typeComboBox.ValueMember = "Id";
			// 
			// producerComboBox
			// 
			this.producerComboBox.DisplayMember = "Name";
			this.producerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.producerComboBox.FormattingEnabled = true;
			this.producerComboBox.Location = new System.Drawing.Point(70, 65);
			this.producerComboBox.Name = "producerComboBox";
			this.producerComboBox.Size = new System.Drawing.Size(229, 21);
			this.producerComboBox.TabIndex = 2;
			this.producerComboBox.ValueMember = "Id";
			// 
			// producerLabel
			// 
			this.producerLabel.AutoSize = true;
			this.producerLabel.Location = new System.Drawing.Point(15, 69);
			this.producerLabel.Name = "producerLabel";
			this.producerLabel.Size = new System.Drawing.Size(50, 13);
			this.producerLabel.TabIndex = 2;
			this.producerLabel.Text = "Producer";
			// 
			// TradingEquipmentModelDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(320, 125);
			this.Controls.Add(this.producerComboBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.producerLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TradingEquipmentModelDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trading Equipment Model";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ComboBox producerComboBox;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label producerLabel;
	}
}