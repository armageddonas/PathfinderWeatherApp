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

        /// <summary>
        /// returns the elements of the specified column from table given.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="orderColumn"></param>
        /// <returns></returns>
        public object[] GetComboBoxData(string table, string column, string orderColumn)
        {
            if (ConnOpen())
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select " + column + " from " + table;
                if (orderColumn != null)
                {
                    cmd.CommandText += " order by " + orderColumn;
                }

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

        /// <summary>
        /// returns base temperature in position 0, prec intensity adj in position 1, prec frenquency name in position 2, temperature template in position 3.
        /// </summary>
        /// <param name="climate"></param>
        /// <param name="position"></param>
        /// <returns></returns>
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
                        list.Add(reader.GetValue(10).ToString());
                    }
                    reader.Close();
                    cmd.Dispose();
                    ConnClose();
                    return list;
                };
            }
            return null; 
        }

        /// <summary>
        /// returns temperature adj in position 0, prec intensity in pos 1, prec frequency adj in position 2.
        /// </summary>
        /// <param name="elevation"></param>
        /// <returns></returns>
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
