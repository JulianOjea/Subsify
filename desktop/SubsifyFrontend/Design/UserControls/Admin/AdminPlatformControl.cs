﻿using SubsifyFrontend.Design.Forms.Admin;
using SubsifyFrontend.Design.Forms.User;
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
    public partial class AdminPlatformControl : UserControl
    {
        public Request request { get; set; }
        public List<RequestObject> srTable;
        public AdminPlatformControl()
        {
            this.request = request;
            InitializeComponent();

            lv_platf.View = View.Details;
            lv_platf.FullRowSelect = true;
            lv_platf.Columns.Add("PLATF_ID", 0);
            lv_platf.Columns.Add("Plataforma", 150);
            lv_platf.Columns.Add("Categoría", 120);
        }

        public void setListView(List<RequestObject> srTable)
        {
            this.srTable = srTable;
            foreach (RequestObject srRow in srTable)
            {
                ListViewItem item = new ListViewItem(srRow.PLATF_ID.ToString());
                item.SubItems.Add(srRow.PLATF_NAME);
                item.SubItems.Add(srRow.CAT_NAME);

                lv_platf.Items.Add(item);
            }
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            AdminAddPlatformForm adminAddPlatformForm = new AdminAddPlatformForm(request);
            DialogResult result = adminAddPlatformForm.ShowDialog();
        }

        private void AdminPlatformControl_Load(object sender, EventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            filterListView(this.tb_search.Text);
        }

        private void filterListView(string filtro)
        {
            lv_platf.Items.Clear();

            foreach (RequestObject srRow in srTable)
            {
                if (srRow.PLATF_NAME.ToLower().Contains(filtro.ToLower()) ||
                    srRow.CAT_NAME.ToLower().Contains(filtro.ToLower()))
                {
                    ListViewItem item = new ListViewItem(srRow.PLATF_ID.ToString());
                    item.SubItems.Add(srRow.PLATF_NAME);
                    item.SubItems.Add(srRow.CAT_NAME);

                    lv_platf.Items.Add(item);
                }
            }
        }
    }
}
