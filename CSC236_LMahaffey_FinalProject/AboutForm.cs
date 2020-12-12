using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_LMahaffey_FinalProject
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            layoutControls();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Activated(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void layoutControls()
        {
            label1.Location = new Point()
            {
                X = ((this.Width / 2) - (label1.Width / 2)),
                Y = label1.Location.Y
            };
            label2.Location = new Point()
            {
                X = ((this.Width / 2) - (label2.Width / 2)),
                Y = label2.Location.Y
            };
            OK_Button.Location = new Point()
            {
                X = ((this.Width / 2) - (OK_Button.Width / 2)),
                Y = OK_Button.Location.Y
            };
        }
    }
}
