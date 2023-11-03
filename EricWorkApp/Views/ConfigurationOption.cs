using EricWorkApp.Helper;
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
    public partial class ConfigurationOption : Form
    {
        private WorkHoursModel workHoursModel;

        public ConfigurationOption()
        {
            InitializeComponent();
            LoadWorkHours();
            LoadTotalHours();
        }

        private void ConfigurationOption_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadTotalHours()
        {
            try
            {
                lbl_total_hours.Text = ConvertHours.RestBetweenHours(dtp_start_date.Value, dtp_end_date.Value);
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

               List<WorkHours> workHours = workHoursModel.GetWorkHours();
                dgv_WorkHours.Rows.Clear();

                foreach (var item in workHours)
                {
                    dgv_WorkHours.Rows.Add(item.ID, item.Code, item.StartDate, item.EndDate );
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void btn_add_work_hourary_Click(object sender, EventArgs e)
        {
            try
            {
                

                var validateHours = ConvertHours.RestBetweenHours(dtp_start_date.Value, dtp_end_date.Value);

                if (!string.IsNullOrEmpty(txt_code.Text) && !string.IsNullOrEmpty(validateHours))
                {
                    WorkHours workHours = new WorkHours();
                    lbl_total_hours.Text = validateHours + " Hour";


                    workHours.Code = txt_code.Text;
                    workHours.StartDate = dtp_start_date.Text;
                    workHours.EndDate = dtp_end_date.Text;

                    workHoursModel = new WorkHoursModel();

                    int result = workHoursModel.InsertWorkHour(workHours);

                    if (result == 0)
                    {
                        MessageBox.Show("No se logro crear el nuevo horario de trabajo! \n\n Trate de nuevo o comuniquese con el soporte tecnico!");
                    }
                    else
                    {
                        txt_code.Text = string.Empty;
                        LoadWorkHours();
                    }
                }
                else
                {
                    MessageBox.Show("Verify the hours from and to have no problems. \nAlso remember that the code field cannot be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delete_work_horary_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgv_WorkHours.CurrentRow.Cells[0].Value;

                int result = workHoursModel.DeleteWorkHoursById(id);

                if (result == 0)
                {
                    MessageBox.Show("No se logro eliminar el horario de trabajo! \n\n Trate de nuevo o comuniquese con el soporte tecnico!");
                }
                else
                {
                    LoadWorkHours();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }

        private void dtp_end_date_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                lbl_total_hours.Text = ConvertHours.RestBetweenHours(dtp_start_date.Value, dtp_end_date.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
          
        }

        private void dtp_start_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_total_hours.Text = ConvertHours.RestBetweenHours(dtp_start_date.Value, dtp_end_date.Value);

            }
            catch (Exception ex)
            {

                MessageBox.Show("This is a ERROR? \n\n {" + ex.Message + "}");
            }
        }
    }
}
