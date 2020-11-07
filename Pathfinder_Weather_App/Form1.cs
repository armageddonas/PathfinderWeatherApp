using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Weather_App
{
    public partial class Form1 : Form
    {
        bool firstTime = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataMapper dm = new DataMapper();
            climateComboBox.Items.AddRange(dm.GetComboBoxData("Climates", "Climate", null));
            elevationComboBox.Items.AddRange(dm.GetComboBoxData("Elevations", "Elevation", "Elevation"));

            //comboboxes default selected
            climateComboBox.SelectedItem = "Temperate";
            elevationComboBox.SelectedItem = "Sea Level";
            seasonComboBox.SelectedIndex = 0;
            precFreqComboBox.SelectedItem = "Default";
            precIntensityComboBox.SelectedItem = "Default";
            tempScaleBox.SelectedItem = "Celsius";
            distScaleBox.SelectedItem = "Metric";

        }

        private void generatorButton_Click(object sender, EventArgs e)
        {
            WeatherGenerator wg = new WeatherGenerator(climateComboBox, elevationComboBox, seasonComboBox, precFreqComboBox, precIntensityComboBox);
            dataViewer.Rows.Clear();
            wg.DataShower(dataViewer, tempScaleBox.SelectedItem.ToString(),distScaleBox.SelectedItem.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataViewer.Rows.Clear();
        }

        private void tempScaleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstTime) { return; }
            int rows = dataViewer.RowCount;
            //todo
            for(int i =0;i<rows;i++)
            {
                if (tempScaleBox.SelectedItem.ToString() == "Celsius")
                {
                    dataViewer[2, i].Value = Int32.Parse(dataViewer[2, i].Value.ToString()) * 9 / 5 + 32;
                }
                else
                {
                    dataViewer[2, i].Value = (Int32.Parse(dataViewer[2, i].Value.ToString())-30)/2;
                }
            }
        }
    }
}
