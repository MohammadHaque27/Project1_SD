using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project1_SD
{

    public partial class Form1 : Form
    {
        private DataTable DTable;
        public Form1()
        {
            InitializeComponent();
            DTable = new DataTable();
            DTable.Columns.Add("Ticker");
            DTable.Columns.Add("Period");
            DTable.Columns.Add("Date", typeof(DateTime));
            DTable.Columns.Add("Open", typeof(double));
            DTable.Columns.Add("High", typeof(double));
            DTable.Columns.Add("Low", typeof(double));
            DTable.Columns.Add("Close", typeof(double));
            DTable.Columns.Add("Volume", typeof(int));

            dataGridView.DataSource = DTable;




            //filters
            StartDate.ValueChanged += DataFilter;
            EndDate.ValueChanged += DataFilter;
        }

        //function to filter by date

        private void DataFilter
            (object sender, EventArgs e)
        {
            //Clones Dtable to make FilteredDTable to add filtered dates
            DataTable DTableFiltered = DTable.Clone();
            DateTime TickerEndDate = EndDate.Value.Date.AddDays(1); // Getting Ticker End Date including the EndDate
            DateTime TickerStartDate = StartDate.Value.Date;   //Getting Ticker Start Date


            foreach (DataRow rowofData in DTable.Rows)
            {
                //checking if data is within the selected range
                DateTime TDate = (DateTime)rowofData["Date"];

                if (TDate >= TickerStartDate && TDate < TickerEndDate)
                {
                    DTableFiltered.ImportRow(rowofData); // Add the row to the filtered data
                }
            }

            dataGridView.DataSource = DTableFiltered;//DataGridViews Datasource is set to the created Filtered Table
        }

        private void StockLoader_Click(object sender, EventArgs e)
        {
            //This opens the file dialog to get the user desired CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = openFileDialog.FileName;
                LoadFile(FilePath);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //
        private void LoadFile(string SelectedCSVfilepath)
        {
            try
            {
                //First we need to clear the Data in DTable
                DTable.Rows.Clear();
                string[] l = File.ReadAllLines(SelectedCSVfilepath);


                for (int i = 1; i < l.Length; i++)
                {
                    string x = l[i];
                    string[] Df = TokenizeCSV(x, ',');

                    if (Df.Length == 8) //see if Dflength = 8
                    {
                        //Trim the given double quotes and then need to parse as DateTime
                        DateTime date = DateTime.Parse(Df[2].Trim('\"'));

                        //Filter ticker start and end date and add the exact end date as well
                        DateTime TicSDate = StartDate.Value.Date;
                        DateTime TicEDate = EndDate.Value.Date.AddDays(1);

                        if (date < TicEDate && date >= TicSDate)
                        {
                            DTable.Rows.Add(Df[0].Trim('\"'), Df[1].Trim('\"'), date, double.Parse(Df[3]), double.Parse(Df[4]), double.Parse(Df[5]), double.Parse(Df[6]), int.Parse(Df[7]));
                        }
                    }
                    else
                    {
                        //else throw error message and exit
                        MessageBox.Show("Skipped a line due to an incorrect number of columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                // show thw error message
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        //This function splits the line of text from a csv file into array of fields based on the delimiter
        private string[] TokenizeCSV(string line, char delimiter)
        {
            //variable initializations
            var t = new StringBuilder();

            var temp = new List<string>();

            bool flagQ = false;

            foreach (char text in line)
            {

                if (!flagQ && text == delimiter)
                {
                    temp.Add(t.ToString());
                    t.Clear();
                }
                else if (text == '\"')
                {
                    flagQ = !flagQ;
                }
                else
                {
                    t.Append(text);
                }
            }
            temp.Add(t.ToString());//After the loop add the contents of t to temp
            return temp.ToArray();//Returns the parse columns
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadChart_Click(object sender, EventArgs e)
        {

        }

        private void CandlestickChart_Click(object sender, EventArgs e)
        {

        }
        private void BindDataToChart()
        {
            // Clear any existing series in the chart
            CandlestickChart.Series.Clear();

            // Create a new series for each column in the DataTable
            foreach (DataColumn column in DTable.Columns)
            {
                if (column.DataType == typeof(DateTime))
                {
                    // Create a series for Date values
                    CandlestickChart.Series.Add(column.ColumnName);
                    CandlestickChart.Series[column.ColumnName].Points.DataBindXY(DTable.AsEnumerable().Select(r => r.Field<DateTime>("Date")).ToArray(), DTable.AsEnumerable().Select(r => r.Field<decimal>(column.ColumnName)).ToArray());
                }
                else if (column.DataType == typeof(decimal))
                {
                    // Create a series for decimal values
                    CandlestickChart.Series.Add(column.ColumnName);
                    CandlestickChart.Series[column.ColumnName].Points.DataBindY(DTable.AsEnumerable().Select(r => r.Field<decimal>(column.ColumnName)).ToArray());
                }
            }
            // Set chart title and axis labels as needed
            CandlestickChart.Titles.Add("Candlestick Chart");
            CandlestickChart.ChartAreas[0].AxisX.Title = "Date";
            CandlestickChart.ChartAreas[0].AxisY.Title = "Value";
        }
    }


    //This is the CandleStick class defining a candlestick
    public class CandleStick
    {
        public string Ticker { get; set; }
        public string Period { get; set; }
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int Volume { get; set; }

    }
}
