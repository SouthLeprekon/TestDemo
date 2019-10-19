namespace Gui.Modules.TradingEquipmentReport
{
	partial class TradingEquipmentReportView
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
			this.topPanel = new System.Windows.Forms.Panel();
			this.minPurchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.minPurchaseDateLabel = new System.Windows.Forms.Label();
			this.toExcelButton = new System.Windows.Forms.Button();
			this.showButton = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tradingEquipmentModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.equipmentTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.producerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.providerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchasedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.minPurchaseDateTimePicker);
			this.topPanel.Controls.Add(this.minPurchaseDateLabel);
			this.topPanel.Controls.Add(this.toExcelButton);
			this.topPanel.Controls.Add(this.showButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1255, 43);
			this.topPanel.TabIndex = 2;
			// 
			// minPurchaseDateTimePicker
			// 
			this.minPurchaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.minPurchaseDateTimePicker.Location = new System.Drawing.Point(116, 12);
			this.minPurchaseDateTimePicker.Name = "minPurchaseDateTimePicker";
			this.minPurchaseDateTimePicker.Size = new System.Drawing.Size(107, 20);
			this.minPurchaseDateTimePicker.TabIndex = 0;
			// 
			// minPurchaseDateLabel
			// 
			this.minPurchaseDateLabel.AutoSize = true;
			this.minPurchaseDateLabel.Location = new System.Drawing.Point(12, 15);
			this.minPurchaseDateLabel.Name = "minPurchaseDateLabel";
			this.minPurchaseDateLabel.Size = new System.Drawing.Size(98, 13);
			this.minPurchaseDateLabel.TabIndex = 1;
			this.minPurchaseDateLabel.Text = "Min. purchase date";
			// 
			// toExcelButton
			// 
			this.toExcelButton.Location = new System.Drawing.Point(310, 11);
			this.toExcelButton.Name = "toExcelButton";
			this.toExcelButton.Size = new System.Drawing.Size(75, 23);
			this.toExcelButton.TabIndex = 2;
			this.toExcelButton.Text = "To Excel";
			this.toExcelButton.UseVisualStyleBackColor = true;
			// 
			// showButton
			// 
			this.showButton.Location = new System.Drawing.Point(229, 11);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(75, 23);
			this.showButton.TabIndex = 1;
			this.showButton.Text = "Show";
			this.showButton.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradingEquipmentModelColumn,
            this.equipmentTypeColumn,
            this.producerColumn,
            this.providerColumn,
            this.locationColumn,
            this.purchasedColumn,
            this.amountColumn});
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView.Location = new System.Drawing.Point(0, 43);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1255, 500);
			this.dataGridView.TabIndex = 0;
			// 
			// tradingEquipmentModelColumn
			// 
			this.tradingEquipmentModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tradingEquipmentModelColumn.DataPropertyName = "TradingEquipmentModel";
			this.tradingEquipmentModelColumn.HeaderText = "Trading Equipment Model";
			this.tradingEquipmentModelColumn.Name = "tradingEquipmentModelColumn";
			this.tradingEquipmentModelColumn.ReadOnly = true;
			// 
			// equipmentTypeColumn
			// 
			this.equipmentTypeColumn.DataPropertyName = "EquipmentType";
			this.equipmentTypeColumn.HeaderText = "Equipment Type";
			this.equipmentTypeColumn.Name = "equipmentTypeColumn";
			this.equipmentTypeColumn.ReadOnly = true;
			this.equipmentTypeColumn.Width = 180;
			// 
			// producerColumn
			// 
			this.producerColumn.DataPropertyName = "Producer";
			this.producerColumn.HeaderText = "Producer";
			this.producerColumn.Name = "producerColumn";
			this.producerColumn.ReadOnly = true;
			this.producerColumn.Width = 180;
			// 
			// providerColumn
			// 
			this.providerColumn.DataPropertyName = "Provider";
			this.providerColumn.HeaderText = "Provider";
			this.providerColumn.Name = "providerColumn";
			this.providerColumn.ReadOnly = true;
			this.providerColumn.Width = 180;
			// 
			// locationColumn
			// 
			this.locationColumn.DataPropertyName = "Location";
			this.locationColumn.HeaderText = "Location";
			this.locationColumn.Name = "locationColumn";
			this.locationColumn.ReadOnly = true;
			this.locationColumn.Width = 180;
			// 
			// purchasedColumn
			// 
			this.purchasedColumn.DataPropertyName = "Purchased";
			this.purchasedColumn.HeaderText = "Purchased";
			this.purchasedColumn.Name = "purchasedColumn";
			this.purchasedColumn.ReadOnly = true;
			this.purchasedColumn.Width = 150;
			// 
			// amountColumn
			// 
			this.amountColumn.DataPropertyName = "Amount";
			this.amountColumn.HeaderText = "Amount";
			this.amountColumn.Name = "amountColumn";
			this.amountColumn.ReadOnly = true;
			this.amountColumn.Width = 150;
			// 
			// TradingEquipmentReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 543);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.topPanel);
			this.Name = "TradingEquipmentReportView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trading Equipment Report";
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button showButton;
		private System.Windows.Forms.Label minPurchaseDateLabel;
		private System.Windows.Forms.DateTimePicker minPurchaseDateTimePicker;
		private System.Windows.Forms.Button toExcelButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn tradingEquipmentModelColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn producerColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn providerColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchasedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
	}
}