using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricWorkApp.Model
{
    internal class WorkHours
    {
        public int ID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set;} = string.Empty;
    }
}
