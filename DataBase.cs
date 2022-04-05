using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsBulldozer
{
    public class DataBase
    {
        static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        public void OpenConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void CloseConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connect;
        }
        public bool IsOpen()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                return false;
            return true;
        }
        public void DeleteAllFromBD()
        {
            var comand = new SqlCommand("TRUNCATE TABLE [Parkings]", this.getConnection());
            comand.ExecuteNonQuery();
            comand = new SqlCommand("TRUNCATE TABLE [Bulldozers]", this.getConnection());
            comand.ExecuteNonQuery();
            comand = new SqlCommand("TRUNCATE TABLE [Ev]", this.getConnection());
            comand.ExecuteNonQuery();
            this.CloseConnection();
            this.OpenConnection();
        }
        public void setParking(string Parking)
        {
            var comand = new SqlCommand("INSERT INTO [Parkings]([ParkingName]) VALUES (@name)", this.getConnection());
            comand.Parameters.AddWithValue("@name", Parking);
            comand.ExecuteNonQuery();
        }
        public void deleteParking(string Parking)
        {
            int ParkingId = WhatParkingID(Parking);
            string sqlSecondQuery = string.Format("DELETE FROM [Bulldozers]WHERE [ParkingId] = '{0}'", ParkingId);
            var comand2 = new SqlCommand(sqlSecondQuery, this.getConnection());
            comand2.ExecuteNonQuery();
            var comand = new SqlCommand("DELETE FROM [Parkings] WHERE [ParkingName] = (@name)", this.getConnection());
            comand.Parameters.AddWithValue("@name", Parking);
            comand.ExecuteNonQuery();
        }
        public void setBulldozer(string Bulldozer, string ParkingID)
        {
            int ParkingId = WhatParkingID(ParkingID);
            string sqlQuery = @"INSERT INTO [Bulldozers]([Bulldozer],[ParkingId])
            VALUES (@nameBulldozer,@nameParking)";
            var comand = new SqlCommand(sqlQuery, this.getConnection());
            comand.Parameters.AddWithValue("@nameBulldozer", Bulldozer);
            comand.Parameters.AddWithValue("@nameParking", ParkingId);
            comand.ExecuteNonQuery();
            string AddBulldozer = String.Format("Добавили автомобиль {0}", Bulldozer);
            AddEventsInBD(AddBulldozer, ParkingId);
        }
        public void deleteBulldozer(string Parking, string bulldozer, string Place)
        {
            int ParkingId = WhatParkingID(Parking);
            var comand = new SqlCommand("DELETE FROM [Bulldozers] WHERE [ParkingId] = (@name) AND [Bulldozer]=(@buldozer)", this.getConnection());
            comand.Parameters.AddWithValue("@name", ParkingId);
            comand.Parameters.AddWithValue("@buldozer", bulldozer);
            comand.ExecuteNonQuery();
            string DelBulldozer = String.Format("Изъят автомобиль {0} с места {1}", bulldozer, Place);
            AddEventsInBD(DelBulldozer, ParkingId);
        }
        public void AddEventsInBD(string WhatEvent, int ParkingID)
        {
            string sqlquery = string.Format(@"INSERT INTO [Ev]([Ev],[ParkingID],[EvDate])VALUES
            (@DelString,@Parking,@CurrentDate)");
            var comand = new SqlCommand(sqlquery, this.getConnection());
            comand.Parameters.AddWithValue("@DelString", WhatEvent);
            comand.Parameters.AddWithValue("@Parking", ParkingID);
            comand.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
            comand.ExecuteNonQuery();
        }
        public bool NewDataBase() //проверка БД на наличие записей, и если они есть true
        {
            string sqlquery = string.Format("SELECT * FROM [Parkings]");
            var comand1 = new SqlCommand(sqlquery, this.getConnection());
            SqlDataReader Reader = comand1.ExecuteReader();
            if (!Reader.Read())
            {
                Reader.Close(); //Если записей нет (первый запуск) создать 5 пустых парковок
                CreateParkings();
                ValueSelectedParking.SelectedParking = "Parking_1";
                return true;
            }
            Reader.Close();
            string sqlquery2 = "SELECT [ParkingName] FROM [Parkings] WHERE [id] = 1";
            var comand2 = new SqlCommand(sqlquery2, this.getConnection());
            SqlDataReader Reader2 = comand2.ExecuteReader();
            string parkingName = "";
            while (Reader2.Read())
                parkingName = Reader2.GetValue(0).ToString();
            Reader2.Close();
            ValueSelectedParking.SelectedParking = parkingName;
            return false;
        }
        public void CreateParkings()
        {
            for (int i = 1; i < 6; ++i)
                this.setParking("Parking_" + i);
        }
        public void loadFromDB()
        {
            String fileNameDataBase = "tempDataBase.txt";
            if (File.Exists(fileNameDataBase))
            {
                File.Delete(fileNameDataBase);
            }
            using (StreamWriter fs = new StreamWriter(fileNameDataBase, true))
            {
                fs.WriteLine("ParkingCollection");
                string sqlquery = string.Format("SELECT * FROM [Parkings]");
                var comand1 = new SqlCommand(sqlquery, this.getConnection());
                SqlDataReader Reader = comand1.ExecuteReader();
                List<string> Parkings = new List<string>();
                while (Reader.Read())
                    Parkings.Add(Reader.GetValue(1).ToString());
                Reader.Close();
                foreach (var level in Parkings)
                {
                    String str = String.Format("Parking:{0}", level);
                    fs.WriteLine(str);
                    int ParkingsId = 0;
                    string sqlquery2 = string.Format("SELECT [id] FROM [Parkings] WHERE [ParkingName] = '{0}'", level);
                    var comand3 = new SqlCommand(sqlquery2, this.getConnection());
                    ParkingsId = (Int32)comand3.ExecuteScalar();
                    string sqlqueryBulldozer = string.Format("SELECT [Bulldozer] FROM [Bulldozers]WHERE [ParkingId] = '{0}'", ParkingsId);
                    var comand2 = new SqlCommand(sqlqueryBulldozer, this.getConnection());
                    SqlDataReader Reader2 = comand2.ExecuteReader();
                    while (Reader2.Read())
                    {
                        string BulldozerObject = Reader2.GetValue(0).ToString();
                        string typeObject = "Bulldozer";
                        if (BulldozerObject.Contains("True") || BulldozerObject.Contains("False"))
                            typeObject = "SuperBulldozer";
                        String carSet = String.Format("{0}:{1}", typeObject, BulldozerObject);
                        fs.WriteLine(carSet);
                    }
                    Reader2.Close();
                }
            }
        }
        public int WhatParkingID(string ParkingName)
        {
            int ParkingId = 0;
            string sqlquery = string.Format("SELECT [id] FROM [Parkings] WHERE [ParkingName] = '{0}'", ParkingName);
            var comand1 = new SqlCommand(sqlquery, this.getConnection());
            ParkingId = (Int32)comand1.ExecuteScalar();
            return ParkingId;
        }
        public List<string> ListParkingsName()
        {
            List<string> ParkingsName = new List<string>();
            string sqlquery = "SELECT [ParkingName] FROM [Parkings]";
            var comand = new SqlCommand(sqlquery, this.getConnection());
            SqlDataReader Reader = comand.ExecuteReader();
            while (Reader.Read())
                ParkingsName.Add(Reader.GetValue(0).ToString());
            Reader.Close();
            return ParkingsName;
        }
        public string textReport(string ParkingName, DateTime OnDate, DateTime ToDate)
        {
            string sqlquery = "";
            int ParkingsId = WhatParkingID(ParkingName);
            sqlquery = string.Format(@"SELECT [Ev] FROM [Ev] WHERE [ParkingID] = '{0}' AND 
            ([EvDate] >= @OnDate AND [EvDate]<= @ToDate)", ParkingsId);
            var comand = new SqlCommand(sqlquery, this.getConnection());
            comand.Parameters.AddWithValue("@OnDate", OnDate.Date);
            comand.Parameters.AddWithValue("@ToDate", ToDate.Date);
            SqlDataReader Reader = comand.ExecuteReader();
            string Report = "";
            while (Reader.Read())
            {
                Report += Reader.GetValue(0).ToString();
                Report += "\n";
            }
            Reader.Close();
            return Report;
        }
    }
}
