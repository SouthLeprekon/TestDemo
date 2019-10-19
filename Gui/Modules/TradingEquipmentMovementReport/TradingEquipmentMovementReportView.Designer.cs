namespace Gui.Modules.TradingEquipmentMovementReport
{
	partial class TradingEquipmentMovementReportView
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
			this.toExcelButton = new System.Windows.Forms.Button();
			this.showButton = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tradingEquipmentModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.equipmentTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.producerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.destinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.toExcelButton);
			this.topPanel.Controls.Add(this.showButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1255, 43);
			this.topPanel.TabIndex = 2;
			// 
			// toExcelButton
			// 
			this.toExcelButton.Location = new System.Drawing.Point(93, 11);
			this.toExcelButton.Name = "toExcelButton";
			this.toExcelButton.Size = new System.Drawing.Size(75, 23);
			this.toExcelButton.TabIndex = 1;
			this.toExcelButton.Text = "To Excel";
			this.toExcelButton.UseVisualStyleBackColor = true;
			// 
			// showButton
			// 
			this.showButton.Location = new System.Drawing.Point(12, 11);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(75, 23);
			this.showButton.TabIndex = 0;
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
            this.sourceColumn,
            this.destinationColumn,
            this.dateColumn,
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
			// sourceColumn
			// 
			this.sourceColumn.DataPropertyName = "Source";
			this.sourceColumn.HeaderText = "Source";
			this.sourceColumn.Name = "sourceColumn";
			this.sourceColumn.ReadOnly = true;
			this.sourceColumn.Width = 180;
			// 
			// destinationColumn
			// 
			this.destinationColumn.DataPropertyName = "Destination";
			this.destinationColumn.HeaderText = "Destination";
			this.destinationColumn.Name = "destinationColumn";
			this.destinationColumn.ReadOnly = true;
			this.destinationColumn.Width = 180;
			// 
			// dateColumn
			// 
			this.dateColumn.DataPropertyName = "Date";
			this.dateColumn.HeaderText = "Date";
			this.dateColumn.Name = "dateColumn";
			this.dateColumn.ReadOnly = true;
			this.dateColumn.Width = 150;
			// 
			// amountColumn
			// 
			this.amountColumn.DataPropertyName = "Amount";
			this.amountColumn.HeaderText = "Amount";
			this.amountColumn.Name = "amountColumn";
			this.amountColumn.ReadOnly = true;
			this.amountColumn.Width = 150;
			// 
			// TradingEquipmentMovementReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 543);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.topPanel);
			this.Name = "TradingEquipmentMovementReportView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trading Equipment Movement Report";
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button showButton;
		private System.Windows.Forms.Button toExcelButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn tradingEquipmentModelColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn equipmentTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn producerColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn destinationColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
	}
}