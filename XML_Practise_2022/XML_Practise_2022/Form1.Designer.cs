namespace XML_Practise_2022
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGW1 = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2To = new System.Windows.Forms.DateTimePicker();
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGW1
            // 
            this.dataGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGW1.Location = new System.Drawing.Point(12, 63);
            this.dataGW1.Name = "dataGW1";
            this.dataGW1.Size = new System.Drawing.Size(666, 426);
            this.dataGW1.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRateData.Legends.Add(legend3);
            this.chartRateData.Location = new System.Drawing.Point(684, 63);
            this.chartRateData.Name = "chartRateData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRateData.Series.Add(series3);
            this.chartRateData.Size = new System.Drawing.Size(769, 426);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerFrom.TabIndex = 2;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.Refresh);
            // 
            // dateTimePicker2To
            // 
            this.dateTimePicker2To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2To.Location = new System.Drawing.Point(147, 12);
            this.dateTimePicker2To.Name = "dateTimePicker2To";
            this.dateTimePicker2To.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker2To.TabIndex = 3;
            this.dateTimePicker2To.ValueChanged += new System.EventHandler(this.Refresh);
            // 
            // cmbValuta
            // 
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cmbValuta.Location = new System.Drawing.Point(298, 12);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(121, 21);
            this.cmbValuta.TabIndex = 4;
            this.cmbValuta.SelectedIndexChanged += new System.EventHandler(this.Refresh);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 556);
            this.Controls.Add(this.cmbValuta);
            this.Controls.Add(this.dateTimePicker2To);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGW1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGW1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2To;
        private System.Windows.Forms.ComboBox cmbValuta;
    }
}

