using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Weather_App
{
    class WeatherGenerator
    {
        int temperatureDuration;//done
        int temperature;//done
        int eventDuration;//done
        int precIntensityAdj;//done
        int precFreq;//done
        int seasonPos;//done
        int rangedPenalty;//done
        int perceptionPenalty;//done
        string cloudcover;

        string windStrength;
        string windSpeed;

        string events;//done
        string eventsVision;//done
        string eventsDesc;//done
        string daytime;//done
        string precIntesity;//done
        string climate;//done
        string elevation;//done
        string season;//done
        string temperatureTemplate;//done
        bool needsClouds;

        Random roller = new Random();
        Random roller2 = new Random();

        public WeatherGenerator(ComboBox climatebox, ComboBox elevationbox, ComboBox seasonbox, ComboBox freqbox, ComboBox intensitybox)
        {            
            climate = climatebox.SelectedItem.ToString();
            elevation = elevationbox.SelectedItem.ToString();
            season = seasonbox.SelectedItem.ToString();
            seasonPos = seasonbox.SelectedIndex;
            precFreq = WeatherTables.freqDictionary[freqbox.SelectedItem.ToString()];
            precIntesity = intensitybox.SelectedItem.ToString();
        }

        void GetData()
        {
            DataMapper dm = new DataMapper();
            List<string> climateList = dm.GetClimateData(climate, seasonPos);
            temperature = Int32.Parse(climateList[0]);
            precIntensityAdj = Int32.Parse(climateList[1]);
            temperatureTemplate = climateList[3];

            if (precFreq == -1)//if frequency is set to default
            {
                precFreq = WeatherTables.freqDictionary[climateList[2]];
            }

            List<string> elevList = dm.GetElevationData(elevation);
            temperature += Int32.Parse(elevList[0]);
            //pos is the intensity value modified by the adjustment due to climate
            int pos = WeatherTables.intensities.FindIndex(a => a.Contains(elevList[1])) + precIntensityAdj;

            if (precFreq == 5)
            {
                pos -= 2;
            }

            //position must be between 0 - 3
            pos = pos < 0 ? 0 : pos;
            pos = pos > 5 ? 3 : pos;

            if (precIntesity == "Default")
            {
                precIntesity = WeatherTables.intensities[pos];//modifies the precipitation intensity by the value gotten from climate. 
            }
        }

        /// <summary>
        /// generates time of the event. (daytime)
        /// </summary>
        void TimeGenerator()
        {
            daytime = WeatherTables.timeOfDay[roller2.Next(0,WeatherTables.timeOfDay.Count)];
        }

        /// <summary>
        /// generates temperature for a semi-random set of days. (temperature, temperatureDuration)
        /// </summary>
        void TemperatureGenerator()
        {             
            int index;
            int roll = roller.Next(1, 101);
            if (temperatureTemplate == "Cold")
            {                
                index = TableSearcher(WeatherTables.coldDictionary, roll);
                temperatureDuration += roller.Next(WeatherTables.coldDictionary[index].Item2, WeatherTables.coldDictionary[index].Item3 + 1);
                int modifier = WeatherTables.coldDictionary[index].Item1 > 0 ? 1 : -1;
                temperature += roller.Next(1 * Math.Abs(WeatherTables.coldDictionary[index].Item1), 10 * Math.Abs(WeatherTables.coldDictionary[index].Item1)) * modifier;
            }
            else if(temperatureTemplate == "Temperate")
            {
                index = TableSearcher(WeatherTables.tempDictionary, roll);
                temperatureDuration += roller.Next(WeatherTables.tempDictionary[index].Item2, WeatherTables.tempDictionary[index].Item3 + 1);
                int modifier = WeatherTables.tempDictionary[index].Item1 > 0 ? 1 : -1;
                temperature += roller.Next(1 * Math.Abs(WeatherTables.tempDictionary[index].Item1), 10 * Math.Abs(WeatherTables.tempDictionary[index].Item1)) * modifier;
            }
            else
            {
                index = TableSearcher(WeatherTables.tropDictionary, roll);
                temperatureDuration = roller.Next(WeatherTables.tropDictionary[index].Item2, WeatherTables.tropDictionary[index].Item3 + 1);
                int modifier = WeatherTables.tropDictionary[index].Item1 > 0 ? 1 : -1;
                temperature += roller.Next(1 * Math.Abs(WeatherTables.tropDictionary[index].Item1), 10 * Math.Abs(WeatherTables.tropDictionary[index].Item1)) * modifier;
            }
        }

        /// <summary>
        /// calculates events and event duration. (events, eventDuration)
        /// </summary>
        void EventGenerator()
        {
            int i = temperature > 32 ? 0 : 1;
            int j = WeatherTables.intensities.IndexOf(precIntesity);
            Dictionary<int, (string, int, int)> table = WeatherTables.EventTables[i, j];
            int roll = roller.Next(1, 101);
            int key = TableSearcher(table, roll);
            events = table[key].Item1;
            eventDuration = roller.Next(table[key].Item2, table[key].Item3 + 1);
            eventsVision = WeatherTables.Mechanics[events].Item1;
            perceptionPenalty += WeatherTables.Mechanics[events].Item2;
            rangedPenalty += WeatherTables.Mechanics[events].Item2;
            eventsDesc = WeatherTables.Mechanics[events].Item3;
            needsClouds = WeatherTables.Mechanics[events].Item4;
        }

        /// <summary>
        /// generates clouds. These are modified by the occasional event and modify the temperature if no event.
        /// </summary>
        /// <param name="isPrec"></param>
        void CloudGenerator(bool isPrec)
        {
            int roll = roller.Next(1, 101);
            if (needsClouds)
            {
                roll = roller.Next(51, 101);
            }
            int key = TableSearcher(WeatherTables.Clouds, roll);
            cloudcover = WeatherTables.Clouds[key];
            if (!isPrec && cloudcover=="Overcast")
            {
                if (season == "Autumn" || season == "Winter")
                {
                    temperature += 10;
                }
                else
                {
                    temperature -= 10;
                }
            }
        }

        void WindGenerator()
        {
            int roll = roller.Next(1, 101);
            if (events!=null)
            {
                if (events.Contains("Fog"))
                {
                    windStrength = "None";
                    windSpeed = "";
                    return;
                }
                if (events.Contains("Thunderstorm"))
                {
                    if (roll < 51)
                    {
                        roll = 90;
                    }else if (roll < 91)
                    {
                        roll = 95;
                    }
                    else
                    {
                        roll = 100;
                    }
                }
            }
            int key = TableSearcher(WeatherTables.Winds, roll);
            windSpeed = roller.Next(WeatherTables.Winds[key].Item2, WeatherTables.Winds[key].Item3 + 1).ToString();
            if (windSpeed != "0")
            {
                windStrength = WeatherTables.Winds[key].Item1;
            }
            rangedPenalty += WeatherTables.Winds[key].Item4;
        }

        /// <summary>
        /// given a dictionary table and a number rolled, returns the row that corresponds to the roll.
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="rolled"></param>
        /// <returns></returns>
        int TableSearcher<T>(Dictionary<int,T> dic, int rolled)
        {
            foreach (int key in dic.Keys)
            {
                if (rolled <= key)
                {
                    return key;
                }
            }
            return -1;
        }

        public List<string> DataShower(DataGridView table,string tempScale,string distScale)
        {
            List<string> list = new List<string>();
            GetData();
            TemperatureGenerator();
            int dholder = temperatureDuration;
            string speednow = null;
            bool isPrec = false;
            for (int i = 0; i < 7; i++)
            {
                int tempnow = 0;
                events = " ";
                eventDuration = 0;
                daytime = " ";
                eventsVision = " ";
                rangedPenalty = 0;
                perceptionPenalty = 0;
                if (i >= dholder)
                {
                    TemperatureGenerator();
                    tempnow = temperature;
                    dholder = i + temperatureDuration;
                }
                int roll = roller.Next(1, 101);
                if (roll < precFreq)
                {
                    TimeGenerator();
                    EventGenerator();
                    isPrec = true;
                }

                CloudGenerator(isPrec);

                WindGenerator();

                if (!String.IsNullOrEmpty(windSpeed))
                {
                    speednow = " (" + windSpeed.ToString() + " mph)";
                    if (distScale == "Metric")
                    {
                        speednow = " (" + Math.Round((Int32.Parse(windSpeed) * 1.609f), 1).ToString() + " km/h)";
                    }
                }
                else
                {
                    speednow = null;
                }
                
                if (tempScale == "Celsius")
                {
                    tempnow = (temperature - 30) / 2;
                }
                string siegePenalty = null;
                if (rangedPenalty <= -50)
                {
                    perceptionPenalty += -8;
                    siegePenalty = " / -4 on siege weapons";
                }
                table.Rows.Add(i+1, tempnow, cloudcover, windStrength+speednow, events, eventDuration.ToString() + " hours", daytime, eventsVision, perceptionPenalty.ToString()+" / "+rangedPenalty.ToString()+siegePenalty, eventsDesc);
            }
            table.Rows.Add(-1, -1, "DONE", "DONE", "DONE", "DONE", "DONE", "DONE", "DONE", "DONE");
            return list;
        }
    }
}
