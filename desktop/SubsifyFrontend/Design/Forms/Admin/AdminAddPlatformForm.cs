using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubsifyFrontend.Design.Forms.Admin
{
    public partial class AdminAddPlatformForm : Form
    {
        Request request;
        List<RequestObject> catList;
        int catId;
        public AdminAddPlatformForm(Request request)
        {
            this.request = request;
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.cb_category.DropDownStyle = ComboBoxStyle.DropDownList;
            this.BackColor = this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);

            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());
        }

        private async void AdminAddPlatformForm_Load(object sender, EventArgs e)
        {
            catList = await this.request.PostAsync("categories/categoryActive/search",
            "\"CAT_ID\",\"CAT_NAME\"",
                "");

            foreach (RequestObject responseRow in catList)
            {
                cb_category.Items.Add(responseRow.CAT_NAME);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bttn_image_select_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PNG|*.png|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pb_image.Image = System.Drawing.Image.FromFile(filePath);
                }

            }
        }

        static string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
        }

        private async void bttn_ok_Click(object sender, EventArgs e)
        {
            Image image = pb_image.Image;
            string imageBase64 = ImageToBase64(image);
            string platf_name = this.tb_platf_name.Text;
            string data = $"{{\"CAT_ID\": {catId}, " +
                $"\"PLATF_NAME\": \"{platf_name}\", " +
                $"\"PLATF_LINK\": \"{this.tb_link.Text}\", " +
                $"\"PLATF_IMAGE\": \"{imageBase64}\"}}";

            string types = "\"PLATF_IMAGE\": 6464";
            await request.PostInsertAsync(
                "platforms/platform",
                data,
                types
                );
            this.Close();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            catId = catList[cb_category.SelectedIndex].CAT_ID;
        }
    }
}
