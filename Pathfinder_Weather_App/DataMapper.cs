using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Weather_App
{
    class DataMapper
    {
        OleDbConnection conn;

        public DataMapper()
        {
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '../../WeatherData.accdb'";
            conn = new OleDbConnection(connectionString);
        }        

        bool ConnOpen()
        {
            try
            {
                conn.Open();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        void ConnClose()
        {
            conn.Close();
        }

        public object[] GetComboBoxData(string table, string column)
        {
            if (ConnOpen())
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select " + column + " from " + table;

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    List<string> list = new List<string>();
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                    reader.Close();
                    cmd.Dispose();
                    ConnClose();
                    return list.Cast<object>().ToArray();
                };              
            }
            return null;
        }

        public List<string> GetClimateData(string climate, int position)
        {
            if (ConnOpen())
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * From Climates Where Climate = '" + climate+"'";

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    List<string> list = new List<string>();
                    while (reader.Read())
                    {
                        list.Add(reader.GetValue(position+1).ToString());                        
                        list.Add(reader.GetValue(5).ToString());                        
                        list.Add(reader.GetValue(position+6).ToString());                        
                    }
                    reader.Close();
                    cmd.Dispose();
                    ConnClose();
                    return list;
                };
            }
            return null; 
        }

        public List<string> GetElevationData(string elevation)
        {
            if (ConnOpen())
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Temp_Adj, Prec_Intensity, Prec_Freq_Adj From Elevations Where Elevation = '" + elevation + "'";

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    List<string> list = new List<string>();
                    while (reader.Read())
                    {
                        list.Add(reader.GetValue(0).ToString());
                        list.Add(reader.GetValue(1).ToString());
                        list.Add(reader.GetValue(2).ToString());
                    }
                    reader.Close();
                    cmd.Dispose();
                    ConnClose();
                    return list;
                };
            }
            return null;
        }

    }
}
