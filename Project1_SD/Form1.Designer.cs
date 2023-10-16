namespace Project1_SD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.StockLoader = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CandlestickChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VolumeGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandlestickChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StockLoader
            // 
            this.StockLoader.Location = new System.Drawing.Point(1395, 12);
            this.StockLoader.Name = "StockLoader";
            this.StockLoader.Size = new System.Drawing.Size(185, 75);
            this.StockLoader.TabIndex = 0;
            this.StockLoader.Text = "StockLoader";
            this.StockLoader.UseVisualStyleBackColor = true;
            this.StockLoader.Click += new System.EventHandler(this.StockLoader_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickerDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.candleStickBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1256, 295);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(1349, 138);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(399, 31);
            this.StartDate.TabIndex = 2;
            this.StartDate.ValueChanged += new System.EventHandler(this.StockLoader_Click);
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(1349, 201);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(399, 31);
            this.EndDate.TabIndex = 3;
            this.EndDate.ValueChanged += new System.EventHandler(this.StockLoader_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1497, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1497, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "End";
            // 
            // CandlestickChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CandlestickChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CandlestickChart.Legends.Add(legend1);
            this.CandlestickChart.Location = new System.Drawing.Point(12, 313);
            this.CandlestickChart.Name = "CandlestickChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.CandlestickChart.Series.Add(series1);
            this.CandlestickChart.Size = new System.Drawing.Size(1256, 300);
            this.CandlestickChart.TabIndex = 6;
            this.CandlestickChart.Text = "Candlestickchart";
            this.CandlestickChart.Click += new System.EventHandler(this.CandlestickChart_Click);
            // 
            // VolumeGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.VolumeGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.VolumeGraph.Legends.Add(legend2);
            this.VolumeGraph.Location = new System.Drawing.Point(12, 619);
            this.VolumeGraph.Name = "VolumeGraph";
            this.VolumeGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.VolumeGraph.Series.Add(series2);
            this.VolumeGraph.Size = new System.Drawing.Size(1256, 300);
            this.VolumeGraph.TabIndex = 7;
            this.VolumeGraph.Text = "chart2";
            title1.Name = "VolumeGraph";
            this.VolumeGraph.Titles.Add(title1);
            // 
            // tickerDataGridViewTextBoxColumn
            // 
            this.tickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker";
            this.tickerDataGridViewTextBoxColumn.HeaderText = "Ticker";
            this.tickerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tickerDataGridViewTextBoxColumn.Name = "tickerDataGridViewTextBoxColumn";
            this.tickerDataGridViewTextBoxColumn.Width = 200;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            this.openDataGridViewTextBoxColumn.HeaderText = "Open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.Width = 200;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.Width = 200;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.Width = 200;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "Close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.Width = 200;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 200;
            // 
            // candleStickBindingSource
            // 
            this.candleStickBindingSource.DataSource = typeof(Project1_SD.CandleStick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Project1_SD.Form1);
            // 
            // LoadChart
            // 
            this.LoadChart.Location = new System.Drawing.Point(1413, 261);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(199, 60);
            this.LoadChart.TabIndex = 8;
            this.LoadChart.Text = "LoadChart";
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.LoadChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 915);
            this.Controls.Add(this.LoadChart);
            this.Controls.Add(this.VolumeGraph);
            this.Controls.Add(this.CandlestickChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.StockLoader);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.StockLoader_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CandlestickChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StockLoader;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource candleStickBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CandlestickChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VolumeGraph;
        private System.Windows.Forms.Button LoadChart;
    }
}

