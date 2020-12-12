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
    public partial class ErrorForm : Form
    {
        public string Message { get; set; }
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Activated(object sender, EventArgs e)
        {
            Message_Label.Text = Message;
            layoutControls();
            this.TopMost = true;
        }
        private void layoutControls()
        {
            Message_Label.Location = new Point()
            {
                X = ((this.Width / 2) - (Message_Label.Width / 2)),
                Y = Message_Label.Location.Y
            };
            OK_Button.Location = new Point()
            {
                X = ((this.Width / 2) - (OK_Button.Width / 2)),
                Y = OK_Button.Location.Y
            };
        }
    }
}
