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
        int day, temperature, duration, precIntensityAdj;
        string timeOfDay, cloudcover, windStrength, events, precIntesity;

        List<string> intensities = new List<string>{ "Light", "Medium", "Heavy", "Torrential" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataMapper dm = new DataMapper();
            climateComboBox.Items.AddRange(dm.GetComboBoxData("Climates", "Climate"));
            elevationComboBox.Items.AddRange(dm.GetComboBoxData("Elevations", "Elevation"));
            precFreqComboBox.Items.AddRange(dm.GetComboBoxData("Precipitation_Frequency", "Frequency"));

            //comboboxes default selected
            climateComboBox.SelectedIndex = 0;
            elevationComboBox.SelectedIndex = 0;
            seasonComboBox.SelectedIndex = 0;
            precFreqComboBox.SelectedIndex = 0;
            precIntensityComboBox.SelectedIndex = 0;

        }

        private void generatorButton_Click(object sender, EventArgs e)
        {
            Generator();


        }

        void Generator()
        {
            DataMapper dm = new DataMapper();
            List<string> tempList = dm.GetClimateData(climateComboBox.SelectedItem.ToString(), seasonComboBox.SelectedIndex);
            temperature = Int32.Parse(tempList[0]);
            precIntensityAdj = Int32.Parse(tempList[1]);

            tempList = dm.GetElevationData(elevationComboBox.SelectedItem.ToString());
            temperature += Int32.Parse(tempList[0]);
            precIntesity = intensities[intensities.FindIndex(a => a.Contains(tempList[1])) + precIntensityAdj];//modifies the precipitation intensity by the value gotten from climate. 


        }
    }
}
