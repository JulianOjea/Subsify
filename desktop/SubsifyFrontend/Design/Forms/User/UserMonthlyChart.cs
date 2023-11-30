using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SubsifyFrontend.Design.Forms.User
{
    public partial class UserMonthlyChart : Form
    {
        List<RequestObject> subList;
        public UserMonthlyChart(List<RequestObject> subList)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.subList = subList;

            this.BackColor = this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);
            configureChart();
            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());
        }

        private void configureChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;

            foreach (var item in subList)
            {
                chart1.Series["Series1"].Points.AddXY(item.PLATF_NAME, item.shared_price);
            }
        }
    }
}
