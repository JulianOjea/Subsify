using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SubsifyFrontend.Design.UserControls.User
{
    public partial class UserHomeCardControl : UserControl
    {
        private string link;
        public UserHomeCardControl()
        {
            InitializeComponent();
            this.bttn_cancelar.Visible = false;
        }

        private void UserHomeCardControl_Load(object sender, EventArgs e)
        {

        }

        public void setContent(RequestObject sr)
        {
            this.lbl_platf_name.Text = sr.PLATF_NAME;
            using (MemoryStream ms = new MemoryStream(sr.PLATF_IMAGE.bytes))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                this.pb_PLATF_IMAGE.Image = image;
                this.pb_PLATF_IMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            DateTime subLapseEnd = sr.SUB_LAPSE_END.AddDays(1);
            this.lbl_end.Text = $"Termina el {subLapseEnd.ToString("d MMM yyyy")}";

            TimeSpan dateDiff = subLapseEnd - DateTime.UtcNow;
            int daysDiff = (int)dateDiff.TotalDays;
            

            if (!sr.SUBS_AUTORENEWAL)
            {
                this.lbl_renew.Text = $"Caduca en {daysDiff} días";
                this.bttn_cancelar.Visible = true;
            }
            else
            {
                this.lbl_renew.Text = $"Se renueva en {daysDiff} días";
            }
            link = sr.PLATF_LINK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
