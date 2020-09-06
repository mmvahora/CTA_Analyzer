//
// CTA Ridership analysis.
//
// Moin Vahora
// U. of Illinois, Chicago
// CS341, Fall2017
// Project #07
//
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CTA_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listboxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.Cursor = Cursors.WaitCursor;

            clearForm2();


            string filename1, version, connectionInfo;
            SqlConnection db;
            object result;

            version = "MSSQLLocalDB";
            filename1 = "CTA.mdf";

            connectionInfo = String.Format(@"
            Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename1);
            db = new SqlConnection(connectionInfo);
            db.Open();
            string sql1, sql2, sql3;
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = db;

            string name = this.listboxStations.Text;
            name = name.Replace("'", "''");

            sql1 = string.Format(@" 
            SELECT StationID FROM Stations
            WHERE Name = '{0}'
            ", name);

            cmd.CommandText = sql1;
            result = cmd.ExecuteScalar();

            sql2 = string.Format(@" 
            SELECT Name FROM Stops
            WHERE StationID = '{0}'
            ORDER BY Name ASC;
            ", result);
            cmd.CommandText = sql2;

            sql3 = string.Format(@" 
            SELECT SUM(DailyTotal) AS StationTOTAL, SUM(DailyTotal)/COUNT(*) AS AVG,
            (
            SELECT SUM(CONVERT(BIGINT,DailyTotal)) FROM Riderships
            ) AS TOTAL
            FROM Riderships
            WHERE StationID = '{0}'
            ", result);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            
            adapter.Fill(ds);
            //db.Close();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                this.listboxStops.Items.Add(row["Name"]);
                
            }
            cmd.CommandText = sql3;
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            List<double> stationTot = new List<double>();
            List<double> avg = new List<double>();
            List<double> tot = new List<double>();
            

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
            
                stationTot.Add(Convert.ToInt64(row["StationTOTAL"]));
                avg.Add(Convert.ToInt64(row["AVG"]));
                tot.Add(Convert.ToInt64(row["TOTAL"]));
              

            }
            double percent = ((double)stationTot[0] / (double)tot[0]) *100.0;
            //MessageBox.Show(percent.ToString());
            this.textboxRidership.Text = string.Format("{0:#,##0}", stationTot[0]);
            this.textboxAVG.Text = string.Format("{0:#,##0} /day", avg[0]);
            this.textboxPercent.Text = string.Format("{0:F3} %", percent);
            this.listboxStops.SelectedIndex = 0;
            this.Cursor = Cursors.Default;
        }

        private bool fileExists(string filename)
        {
            if (!System.IO.File.Exists(filename))
            {
                string msg = string.Format("Input file not found: '{0}'",
                  filename);

                MessageBox.Show(msg);
                return false;
            }

            // exists!
            return true;
        }

        private void clearForm()
        {
            this.listboxStations.Items.Clear();
            this.listboxStations.Refresh();
        }

        private void clearForm2()
        {
            this.listboxStops.Items.Clear();
            this.listboxStops.Refresh();
        }

        private void clearForm3()
        {
            this.listboxLines.Items.Clear();
            this.listboxLines.Refresh();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            this.Cursor = Cursors.WaitCursor;

            clearForm();


            string filename1, version, connectionInfo;
            SqlConnection db;

            version = "MSSQLLocalDB";
            filename1 = "CTA.mdf";

            connectionInfo = String.Format(@"
            Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename1);
            db = new SqlConnection(connectionInfo);
            db.Open();
            string sql, sql1;
            SqlCommand cmd;
            object result;

            sql = @" 
            SELECT Name FROM Stations
            ORDER BY Name
            ";

            sql1 = @"
            SELECT COUNT(*) FROM Stations;
            ";

            cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);
            //db.Close();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                this.listboxStations.Items.Add(row["Name"]);
            }

            cmd.CommandText = sql1;
            result = cmd.ExecuteScalar();
            textboxNumberStations.Text = String.Format("{0}", result);
            this.listboxStations.SelectedIndex = 0;
            this.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection db = null;
            string version, filename1;
            version = "MSSQLLocalDB";
            filename1 = "CTA.mdf";
            try
            {
                string connectionInfo = String.Format(@"
                Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename1);
                db = new SqlConnection(connectionInfo);
                db.Open();
            }
            catch
            {
                
            }
            finally
            {
                if (db!=null && db.State == ConnectionState.Open)
                {
                    db.Close();
                }
            }

        }

        private void listboxStops_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            clearForm3();


            string filename1, version, connectionInfo;
            SqlConnection db;
            object result;

            version = "MSSQLLocalDB";
            filename1 = "CTA.mdf";

            connectionInfo = String.Format(@"
            Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename1);
            db = new SqlConnection(connectionInfo);
            db.Open();
            string sql1, sql2, sql3;
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = db;

            string name = this.listboxStops.Text;
            name = name.Replace("'", "''");

            string name1 = this.listboxStations.Text;
            name1 = name1.Replace("'", "''");

            sql1 = string.Format(@" 
            SELECT ADA, Direction, Latitude, Longitude 
            FROM Stops
            WHERE Name = '{0}';
            ", name);

            sql2 = string.Format(@" 
            SELECT Color
            FROM Lines, StopDetails, Stops
            WHERE Name = '{0}' AND
	              Stops.StopID = StopDetails.StopID AND
	              StopDetails.LineID = Lines.LineID
            ", name);

            sql3 = string.Format(@" 
            SELECT SUM(DailyTotal) AS Riders
            FROM Riderships, Stations
            WHERE  Name = '{0}' AND
	               Stations.StationID = Riderships.StationID
            GROUP BY TypeOfDay;
            ", name1);

            cmd.CommandText = sql1;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            List<int> Handi = new List<int>();
            List<char> Direct = new List<char>();
            List<string> Lat = new List<string>();
            List<string> Long = new List<string>();

            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
               Handi.Add(Convert.ToInt32(row["ADA"]));
               Direct.Add(Convert.ToChar(row["Direction"]));
               Lat.Add(Convert.ToString(row["Latitude"]));
               Long.Add(Convert.ToString(row["Longitude"]));

            }
            this.textboxDirection.Text = string.Format("{0}", Direct[0]);
            this.textboxLocation.Text = string.Format("({0} , {1})", Lat[0], Long[0]);
            if (Handi[0]==1)
            {
                this.textboxHandicap.Text = "Yes";
            }
            else
            {
                this.textboxHandicap.Text = "No";
            }

            cmd.CommandText = sql2;
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();

            adapter.Fill(ds);
            
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                
                this.listboxLines.Items.Add(row["Color"]);
            }

            cmd.CommandText = sql3;
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();

            adapter.Fill(ds);
            List<double> days = new List<double>();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                days.Add(Convert.ToInt64(row["Riders"]));
                
            }
            textboxWeekday.Text = string.Format("{0:#,##0}", days[0]);
            textboxSaturday.Text = string.Format("{0:#,##0}", days[1]);
            textboxSunday.Text = string.Format("{0:#,##0}", days[2]);
            this.Cursor = Cursors.Default;
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename1, version, connectionInfo;
            SqlConnection db;
            object result;

            version = "MSSQLLocalDB";
            filename1 = "CTA.mdf";

            connectionInfo = String.Format(@"
            Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, filename1);
            db = new SqlConnection(connectionInfo);
            db.Open();
            string sql1;
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = db;

            sql1 = @"
            SELECT TOP 10 Name, SUM(CONVERT(BIGINT,DailyTotal)) AS Riders FROM Stations, Riderships
            WHERE Stations.StationID = Riderships.StationID
            GROUP BY Name
            ORDER BY Riders DESC;
            ";

            cmd.CommandText = sql1;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            List<string> names = new List<string>();
            List<double> riders = new List<double>();
            foreach (DataRow row in ds.Tables["TABLE"].Rows)
            {
                names.Add(Convert.ToString(row[0]));
                riders.Add(Convert.ToInt64(row[1]));

            }

            string[] Results = new string[names.Count];
            for (int i=0; i<names.Count; i++)
            {
                Results[i] = String.Format(@"{0}.) {1} : {2:#,##2}@", i+1, names[i], riders[i]);
                Results[i] = Results[i].Replace("@",   System.Environment.NewLine);

            }
            string toDisplay = string.Join(Environment.NewLine, Results);
            MessageBox.Show(toDisplay);
        }
    }
}
