using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EricWorkApp.Model
{
    internal class WorkHoursModel
    {
        private readonly string connection = ConfigurationManager.ConnectionStrings["Connection_DB"].ConnectionString;

        public int InsertWorkHour(WorkHours workHours)
        {
            var result = 0;
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    using(SQLiteCommand cmd = new SQLiteCommand(conn)) 
                    {
                        

                        cmd.CommandText = "INSERT INTO WORKHOURS (CODE, STARTDATE, ENDDATE) VALUES (@code, @startdate, @enddate);";
                        cmd.Parameters.AddWithValue("@code", workHours.Code);
                        cmd.Parameters.AddWithValue("@startdate", workHours.StartDate);
                        cmd.Parameters.AddWithValue("@enddate", workHours.EndDate);

                        result = cmd.ExecuteNonQuery();

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
                return result;
            }

        }

        public List<WorkHours> GetWorkHours()
        {
            try
            {
                using(SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "SELECT * FROM WORKHOURS;";
                        using(SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            List<WorkHours> workHours = new List<WorkHours>();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    workHours.Add(new WorkHours()
                                    {
                                        ID = reader.GetInt32(0),
                                        Code = reader.GetString(1),
                                        StartDate = reader.GetString(2),
                                        EndDate = reader.GetString(3),
                                    });
                                }
                            }

                            return workHours;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
                return new List<WorkHours> { null };
            }
        }

        public int DeleteWorkHoursById(int ID) {
            var result = 0;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {


                        cmd.CommandText = "DELETE FROM WORKHOURS WHERE ID = @ID;";
                        cmd.Parameters.AddWithValue("@ID", ID);

                        result = cmd.ExecuteNonQuery();

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
                return result;
            }
        }

    }
}
