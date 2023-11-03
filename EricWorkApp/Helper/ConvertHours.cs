using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricWorkApp.Helper
{
    internal class ConvertHours
    {

        public static string RestBetweenHours(DateTime startDate, DateTime endDate)
        {
            try
            {
                string result = string.Empty;

                DateTime startTime = startDate;
                DateTime endTime = endDate;

                TimeSpan diferenceTime = endTime.Subtract(startTime);

                TimeSpan roundedTimeSpan = TimeSpan.FromMinutes(Math.Round(diferenceTime.TotalMinutes));

                result = (roundedTimeSpan.Hours < 1 ? roundedTimeSpan.Hours + 24 : roundedTimeSpan.Hours).ToString();
                

                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is an ERROR? \n\n {" + ex.Message + "}");
                return string.Empty;
            }
        }
    }
}
