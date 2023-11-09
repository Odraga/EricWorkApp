using EricWorkApp.Helper;
using EricWorkApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricWorkApp.Views
{
    public partial class ValidateHoraryOption : Form
    {
        private WorkHoursModel workHoursModel;
        private WorkHours workHour;
        private List<WorkHours> workHours;
        private bool Monday = false;
        private bool Tuesday = false;
        private bool Wednesday = false;
        private bool Thursday = false;
        private bool Friday = false;
        private bool Saturday = false;
        private bool Sunday = false;

        //Monday
        private List<WorkHours> mondayWorksHours = new List<WorkHours>();
        //Tuesday
        private List<WorkHours> tuesdayWorksHours = new List<WorkHours>();
        //Wednesday
        private List<WorkHours> wednesdayWorksHours = new List<WorkHours>();
        //Thursday
        private List<WorkHours> thursdayWorksHours = new List<WorkHours>();
        //Friday
        private List<WorkHours> fridayWorksHours = new List<WorkHours>();
        //Saturday
        private List<WorkHours> saturdayWorksHours = new List<WorkHours>();
        //Sunday
        private List<WorkHours> sundayWorksHours = new List<WorkHours>();


        public ValidateHoraryOption()
        {
            InitializeComponent();

            LoadWorkHours();
        }
        private void MinDayWork()
        {
            try
            {
                int day1 = mondayWorksHours.Count > 0 ? 1 : 0;
                int day2 = tuesdayWorksHours.Count > 0 ? 1 : 0;
                int day3 = wednesdayWorksHours.Count > 0 ? 1 : 0;
                int day4 = thursdayWorksHours.Count > 0 ? 1 : 0;
                int day5 = fridayWorksHours.Count > 0 ? 1 : 0;
                int day6 = saturdayWorksHours.Count > 0 ? 1 : 0;
                int day7 = sundayWorksHours.Count > 0 ? 1 : 0;

                lbl_min_days.Text = (day1 +  day2 + day3 + day4 + day5 + day6 + day7).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }
        private void LoadWorkHours()
        {
            try
            {
                workHoursModel = new WorkHoursModel();

                workHours = workHoursModel.GetWorkHours();
                dgv_WorksHorary.Rows.Clear();

                foreach (var item in workHours)
                {
                    dgv_WorksHorary.Rows.Add(item.ID, item.Code, item.StartDate, item.EndDate);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void dgv_WorksHorary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Change_Background_Color()
        {
            try
            {
                flp_Monday.BackColor = Monday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Tuesday.BackColor = Tuesday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Wednesday.BackColor = Wednesday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Thursday.BackColor = Thursday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Friday.BackColor = Friday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Saturday.BackColor = Saturday ? Color.DarkBlue : Color.DeepSkyBlue;
                flp_Sunday.BackColor = Sunday ? Color.DarkBlue : Color.DeepSkyBlue;
            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void Change_Status(string name)
        {
            try
            {
                switch (name)
                {
                    case "Mon":
                        Monday = !Monday;
                        Tuesday = false;
                        Wednesday = false;
                        Thursday = false;
                        Friday = false;
                        Saturday = false;
                        Sunday = false;
                        break;
                    case "Tue":
                        Monday = false;
                        Tuesday = !Tuesday;
                        Wednesday = false;
                        Thursday = false;
                        Friday = false;
                        Saturday = false;
                        Sunday = false;
                        break;
                    case "Wed":
                        Monday = false;
                        Tuesday = false;
                        Wednesday = !Wednesday;
                        Thursday = false;
                        Friday = false;
                        Saturday = false;
                        Sunday = false;
                        break;
                    case "Thu":
                        Monday = false;
                        Tuesday = false;
                        Wednesday = false;
                        Thursday = !Thursday;
                        Friday = false;
                        Saturday = false;
                        Sunday = false;
                        break;
                    case "Fri":
                        Monday = false;
                        Tuesday = false;
                        Wednesday = false;
                        Thursday = false;
                        Friday = !Friday;
                        Saturday = false;
                        Sunday = false;
                        break;
                    case "Sat":
                        Monday = false;
                        Tuesday = false;
                        Wednesday = false;
                        Thursday = false;
                        Friday = false;
                        Saturday = !Saturday;
                        Sunday = false;
                        break;
                    case "Sun":
                        Monday = false;
                        Tuesday = false;
                        Wednesday = false;
                        Thursday = false;
                        Friday = false;
                        Saturday = false;
                        Sunday = !Sunday;
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void flp_Monday_Click(object sender, EventArgs e)
        {

            Change_Status("Mon");
            Change_Background_Color();

        }

        private void flp_Tuesday_Click(object sender, EventArgs e)
        {

            Change_Status("Tue");
            Change_Background_Color();

        }

        private void flp_Wednesday_Click(object sender, EventArgs e)
        {

            Change_Status("Wed");
            Change_Background_Color();
               


        }

        private void flp_Thursday_Click(object sender, EventArgs e)
        {

            Change_Status("Thu");
            Change_Background_Color();



        }

        private void flp_Friday_Click(object sender, EventArgs e)
        {

            Change_Status("Fri");
            Change_Background_Color();



        }

        private void flp_Saturday_Click(object sender, EventArgs e)
        {

            Change_Status("Sat");
            Change_Background_Color();



        }

        private void flp_Sunday_Click(object sender, EventArgs e)
        {

            Change_Status("Sun");
            Change_Background_Color();


        }



        private void dgv_WorksHorary_MouseDown(object sender, MouseEventArgs e)
        {
            


        }

        private bool WorksHoursExists(WorkHours wh, List<WorkHours> itemWorkHours) =>
            itemWorkHours.Exists(x => x.ID == wh.ID && x.Code == wh.Code && x.StartDate == wh.StartDate && x.EndDate == wh.EndDate);

        private void Delete_Item_WorkHours(int ID)
        {
            if (Monday)
            {
                var itemToRemove = mondayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Monday.Controls.Clear();
                    mondayWorksHours.Remove(itemToRemove);
                    Reload_Horary();

                }
            }
            else if (Tuesday)
            {
                var itemToRemove = tuesdayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Tuesday.Controls.Clear();
                    tuesdayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            }
            else if (Wednesday)
            {
                var itemToRemove = wednesdayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Wednesday.Controls.Clear();
                    wednesdayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            }
            else if (Thursday)
            {
                var itemToRemove = thursdayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Thursday.Controls.Clear();
                    thursdayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            }
            else if (Friday)
            {
                var itemToRemove = fridayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Friday.Controls.Clear();
                    fridayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            }
            else if (Saturday)
            {
                var itemToRemove = saturdayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Saturday.Controls.Clear();
                    saturdayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            }
            else if (Sunday) 
            {
                var itemToRemove = sundayWorksHours.SingleOrDefault(r => r.ID == ID);

                if (itemToRemove != null)
                {
                    flp_Sunday.Controls.Clear();
                    sundayWorksHours.Remove(itemToRemove);
                    Reload_Horary();
                }
            } 
            
        }

        private string Plus_All_Label()
        {
            try
            {
                int mondayValue = int.Parse(lbl_Total_Monday.Text);
                int tuesdayValue = int.Parse(lbl_Total_Tuesday.Text);
                int wednesdayValue = int.Parse(lbl_Total_Wednesday.Text);
                int thursdayValue = int.Parse(lbl_Total_Thursday.Text);
                int fridayValue = int.Parse(lbl_Total_Friday.Text);
                int saturdayValue = int.Parse(lbl_Total_Saturday.Text);
                int sundayValue = int.Parse(lbl_total_Sunday.Text);

                 
                return (mondayValue + tuesdayValue + wednesdayValue + thursdayValue + fridayValue + saturdayValue + sundayValue).ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
                return "0";
            }
        }

        private void Reload_Horary()
        {
            try
            {
                DateTime startTime;
                DateTime endTime;

                if (Monday)
                {
                    lbl_Total_Monday.Text = "0";

                    foreach (var item in mondayWorksHours)
                    {

                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        
                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Monday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));
                        
                        lbl_Total_Monday.Text = plusTime.ToString();

                        flp_Monday.Controls.Add(button);
                    }
                }
                else if (Tuesday)
                {
                    lbl_Total_Tuesday.Text = "0";

                    foreach (var item in tuesdayWorksHours)
                    {

                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Tuesday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_Total_Tuesday.Text = plusTime.ToString();                        

                        flp_Tuesday.Controls.Add(button);
                    }

                }
                else if (Wednesday)
                {
                    lbl_Total_Wednesday.Text = "0";

                    foreach (var item in wednesdayWorksHours)
                    {

                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Wednesday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_Total_Wednesday.Text = plusTime.ToString();

                        flp_Wednesday.Controls.Add(button);
                    }

                }
                else if (Thursday)
                {
                    lbl_Total_Thursday.Text = "0";

                    foreach (var item in thursdayWorksHours)
                    {
                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Thursday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_Total_Thursday.Text = plusTime.ToString();

                        flp_Thursday.Controls.Add(button);
                    }

                }
                else if (Friday)
                {
                    lbl_Total_Friday.Text = "0";

                    foreach (var item in fridayWorksHours)
                    {
                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Friday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_Total_Friday.Text = plusTime.ToString();

                        flp_Friday.Controls.Add(button);
                    }

                }
                else if (Saturday)
                {
                    lbl_Total_Saturday.Text = "0";

                    foreach (var item in saturdayWorksHours)
                    {
                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_Total_Saturday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_Total_Saturday.Text = plusTime.ToString();

                        flp_Saturday.Controls.Add(button);
                    }

                }
                else if (Sunday)
                {
                    lbl_total_Sunday.Text = "0";

                    foreach (var item in sundayWorksHours)
                    {
                        Button button = new Button();
                        button.Name = item.ID.ToString();
                        button.Text = item.Code.ToString() + "\n" + item.StartDate + " / " + item.EndDate;
                        button.Size = new Size(86, 45);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;

                        button.Click += (s, ev) =>
                        {
                            Delete_Item_WorkHours(item.ID);
                        };

                        DateTime.TryParseExact(item.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                        DateTime.TryParseExact(item.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                        int plusTime = int.Parse(lbl_total_Sunday.Text) + int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));

                        lbl_total_Sunday.Text = plusTime.ToString();

                        flp_Sunday.Controls.Add(button);
                    }

                }

                lbl_Total_Hours.Text = Plus_All_Label();
            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void dgv_WorksHorary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime startTime;
                DateTime endTime;

                workHour = new WorkHours();
                workHour.ID = (int)dgv_WorksHorary.CurrentRow.Cells[0].Value;
                workHour.Code = dgv_WorksHorary.CurrentRow.Cells[1].Value.ToString();
                workHour.StartDate = dgv_WorksHorary.CurrentRow.Cells[2].Value.ToString();
                workHour.EndDate = dgv_WorksHorary.CurrentRow.Cells[3].Value.ToString();

                if (Monday)
                {
                    bool exist = mondayWorksHours.Count > 0 ? WorksHoursExists(workHour, mondayWorksHours) : false;  

                    if (!exist)
                    {
                        flp_Monday.Controls.Clear();
                        mondayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }
                }
                else if (Tuesday)
                {
                    bool exist = tuesdayWorksHours.Count > 0 ? WorksHoursExists(workHour, tuesdayWorksHours) : false;


                    if (!exist)
                    {
                        flp_Tuesday.Controls.Clear();
                        tuesdayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }

                }
                else if (Wednesday)
                {
                    bool exist = wednesdayWorksHours.Count > 0 ? WorksHoursExists(workHour, wednesdayWorksHours) : false;


                    if (!exist)
                    {
                        flp_Wednesday.Controls.Clear();
                        wednesdayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }

                }
                else if (Thursday)
                {
                    bool exist = thursdayWorksHours.Count > 0 ? WorksHoursExists(workHour, thursdayWorksHours) : false;


                    if (!exist)
                    {
                        flp_Thursday.Controls.Clear();
                        thursdayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }

                }
                else if (Friday)
                {
                    bool exist = fridayWorksHours.Count > 0 ? WorksHoursExists(workHour, fridayWorksHours) : false;


                    if (!exist)
                    {
                        flp_Friday.Controls.Clear();
                        fridayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }

                }
                else if (Saturday)
                {
                    bool exist = saturdayWorksHours.Count > 0 ? WorksHoursExists(workHour, saturdayWorksHours) : false;
                    
                    DateTime.TryParseExact(workHour.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                    DateTime.TryParseExact(workHour.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                    int minTime = int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));
                    /*if(minTime < 4)
                    {
                        MessageBox.Show("Hours per weekend must be less than 4 hours");
                    }*/
                    if (!exist)
                    {
                        flp_Saturday.Controls.Clear();
                        saturdayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }
                }
                else if (Sunday)
                {
                    bool exist = sundayWorksHours.Count > 0 ? WorksHoursExists(workHour, sundayWorksHours) : false;

                    DateTime.TryParseExact(workHour.StartDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime);
                    DateTime.TryParseExact(workHour.EndDate, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime);

                    int minTime = int.Parse(ConvertHours.RestBetweenHours(startTime, endTime));
                    /*if (minTime < 4)
                    {
                        MessageBox.Show("Hours per weekend must be less than 4 hours");
                    }*/
                    

                    if (!exist)
                    {
                        flp_Sunday.Controls.Clear();
                        sundayWorksHours.Add(workHour);
                        Reload_Horary();
                    }
                    else
                    {
                        MessageBox.Show("This schedule has already been added!");
                    }
                }

                MinDayWork();

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text)) 
            {
                LoadWorkHours();
            }
            else
            {
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgv_WorksHorary.Rows)
                {
                    string value = row.Cells[1].Value.ToString();
                    bool exist = value.IndexOf(txt_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0;

                    if (!exist)
                    {
                        rowsToDelete.Add(row);
                    }

                }
                foreach (DataGridViewRow row in rowsToDelete)
                {
                    dgv_WorksHorary.Rows.Remove(row);
                }
            }
        }

        private void flp_Saturday_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
