using SubsifyFrontend.Design.Forms.Admin;
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

namespace SubsifyFrontend.Design.UserControls.Admin
{
    public partial class AdminPlanControl : UserControl
    {
        public Request request { get; set; }
        public AdminPlanControl()
        {
            InitializeComponent();

            lv_plan.View = View.Details;
            lv_plan.FullRowSelect = true;
            lv_plan.Columns.Add("PLAN_ID", 0);
            lv_plan.Columns.Add("Plan de suscripción", 150);
            lv_plan.Columns.Add("Plataforma", 150);
            lv_plan.Columns.Add("Frecuencia", 150);
            lv_plan.Columns.Add("Precio", 120);
        }

        private void AdminPlanControl_Load(object sender, EventArgs e)
        {

        }

        public void setListView(List<RequestObject> srTable)
        {
            foreach (RequestObject srRow in srTable)
            {
                ListViewItem item = new ListViewItem(srRow.PLAN_ID.ToString());
                item.SubItems.Add(srRow.PLAN_NAME);
                item.SubItems.Add(srRow.PLATF_NAME);
                item.SubItems.Add(srRow.FR_NAME);
                item.SubItems.Add(srRow.PLAN_PRICE_VALUE.ToString("C"));

                lv_plan.Items.Add(item);
            }
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            AdminAddPlanForm adminAddPlanForm = new AdminAddPlanForm(request);
            DialogResult result = adminAddPlanForm.ShowDialog();
        }
    }
}
