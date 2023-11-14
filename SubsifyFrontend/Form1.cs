using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SubsifyFrontend.PruebaHttp;

namespace SubsifyFrontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            Console.WriteLine("ahora estas aqui ");
            await PruebaHttp.RunAsync();
        }
    }
}
