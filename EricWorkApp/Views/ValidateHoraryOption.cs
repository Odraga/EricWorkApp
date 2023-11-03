using EricWorkApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private static List<WorkHours> mondayWorksHours = new List<WorkHours>();
        //Tuesday
        private static List<WorkHours> tuesdayWorksHours = new List<WorkHours>();
        //Wednesday
        private static List<WorkHours> wednesdayWorksHours = new List<WorkHours>();
        //Thursday
        private static List<WorkHours> thursdayWorksHours = new List<WorkHours>();
        //Friday
        private static List<WorkHours> fridayWorksHours = new List<WorkHours>();
        //Saturday
        private static List<WorkHours> saturdayWorksHours = new List<WorkHours>();
        //Sunday
        private static List<WorkHours> sundayWorksHours = new List<WorkHours>();


        public ValidateHoraryOption()
        {
            InitializeComponent();

            LoadWorkHours();
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

        private void Add_Button_WorkHoraries()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void dgv_WorksHorary_MouseDown(object sender, MouseEventArgs e)
        {

            workHour = new WorkHours();
            workHour.ID = (int)dgv_WorksHorary.CurrentRow.Cells[0].Value;
            workHour.Code = dgv_WorksHorary.CurrentRow.Cells[1].Value.ToString();
            workHour.StartDate = dgv_WorksHorary.CurrentRow.Cells[2].Value.ToString();
            workHour.EndDate = dgv_WorksHorary.CurrentRow.Cells[3].Value.ToString();

            if(Monday)
            {
                mondayWorksHours.Add(workHour);
            }
            else if(Tuesday)
            {
                tuesdayWorksHours.Add(workHour);
            }else if(Wednesday) 
            { 
                wednesdayWorksHours.Add(workHour);
            }
            else if(Thursday) 
            {
                thursdayWorksHours.Add(workHour);
            }
            else if(Friday) 
            {
                fridayWorksHours.Add(workHour);
            }
            else if(Saturday) 
            { 
                saturdayWorksHours.Add(workHour);
            }
            else if (Sunday) 
            { 
                sundayWorksHours.Add(workHour);
            }
        }
    }
}
