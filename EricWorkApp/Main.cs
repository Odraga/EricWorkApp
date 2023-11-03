using EricWorkApp.Model;
using EricWorkApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricWorkApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_configuration_Click(object sender, EventArgs e)
        {
            ConfigurationOption configurationOption = new ConfigurationOption();

            configurationOption.ShowDialog();
        }
    }
}
