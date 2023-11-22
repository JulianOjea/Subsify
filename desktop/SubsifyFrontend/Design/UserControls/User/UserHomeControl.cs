using SubsifyFrontend.Design.UserControls.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend
{
    public partial class UserHomeControl : UserControl
    {
        public UserHomeControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserHomeControl_Load(object sender, EventArgs e)
        {

        }

        public void clearCards()
        {
            foreach (Control control in flp_cards.Controls)
            {
                control.Dispose();
            }
            this.flp_cards.Controls.Clear();
        }
        public void setCard(UserHomeCardControl card)
        {
            this.flp_cards.Controls.Add(card);
        }

        private void flp_cards_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
