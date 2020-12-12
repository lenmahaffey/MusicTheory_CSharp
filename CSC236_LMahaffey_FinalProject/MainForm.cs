/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: MainForm.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: main form for application
*/

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace CSC236_LMahaffey_FinalProject
{
    public partial class MainForm : Form
    {
        //Constructors
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
            SetScaleData();
            layoutControls();

        }

        //Properties
        private enum scaleType
        {
            Major,
            NaturalMinor,
            MelodicMinor,
            HarmonicMinor
        };
        private string key = "C";
        private scaleType selecetedScaleType = scaleType.Major;
        private Scale scale;
        public new Scale Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        //Methods
        //Build scale with current values and set UI with it.
        void SetScaleData()
        {
            calculateScale();
            if (selecetedScaleType == scaleType.Major)
            {
                RelativeLabel.Text = "Relative Minor:";
            }
            else
            {
                RelativeLabel.Text = "Relative Major:";
            }
            RelativeTextLabel.Text = scale.relative.ToString();
            NotesLabel.Text = scale.GetScaleAsString();
            NameLabel.Text = key + " " + selecetedScaleType;
            ILabel.Text = scale.GetChordAsString(scale.I);
            IILabel.Text = scale.GetChordAsString(scale.II);
            IIILabel.Text = scale.GetChordAsString(scale.III);
            IVLabel.Text = scale.GetChordAsString(scale.IV);
            VLabel.Text = scale.GetChordAsString(scale.V);
            VILabel.Text = scale.GetChordAsString(scale.VI);
            VIILabel.Text = scale.GetChordAsString(scale.VII);
            layoutControls();
        }
        //Center controls on form
        private void layoutControls()
        {
            NameLabel.Location = new Point()
            {
                X = ((panel3.Width / 2) - (NameLabel.Width / 2)),
                Y = NameLabel.Location.Y
            };
            NotesLabel.Location = new Point()
            {
                X = ((panel3.Width / 2) - (NotesLabel.Width / 2)),
                Y = NotesLabel.Location.Y
            };
        }
        private void calculateScale()
        {
            try
            {
                switch (selecetedScaleType)
                {
                    case scaleType.Major:
                        scale = new MajorScale(key);
                        break;
                    case scaleType.NaturalMinor:
                        scale = new NaturalMinorScale(key);
                        break;
                    case scaleType.MelodicMinor:
                        scale = new MelodicMinorScale(key);
                        break;
                    case scaleType.HarmonicMinor:
                        scale = new HarmonicMinorScale(key);
                        break;
                }
            }
            catch (MusicException e)
            {
                ErrorForm error = new ErrorForm();
                error.Message = e.message;
                error.ShowDialog();
            }
        }

        //Bound control methods
        private void GsAfButton_Click(object sender, EventArgs e)
        {
            key = "Af";
            SetScaleData();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            key = "A";
            SetScaleData();
        }

        private void AsBfButton_Click(object sender, EventArgs e)
        {
            key = "Bf";
            SetScaleData();
        }

        private void B_Click(object sender, EventArgs e)
        {
            key = "B";
            SetScaleData();
        }

        private void C_Click(object sender, EventArgs e)
        {
            key = "C";
            SetScaleData();
        }

        private void CsDf_Click(object sender, EventArgs e)
        {
            key = "Df";
            SetScaleData();
        }

        private void D_Click(object sender, EventArgs e)
        {
            key = "D";
            SetScaleData();
        }

        private void DsEf_Click(object sender, EventArgs e)
        {
            key = "Ef";
            SetScaleData();
        }

        private void E_Click(object sender, EventArgs e)
        {
            key = "E";
            SetScaleData();
        }

        private void F_Click(object sender, EventArgs e)
        {
            key = "F";
            SetScaleData();
        }

        private void FsGfButton_Click(object sender, EventArgs e)
        {
            key = "Fs";
            SetScaleData();
        }

        private void G_Click(object sender, EventArgs e)
        {
            key = "G";
            SetScaleData();
        }

        private void MajorLabel_Click(object sender, EventArgs e)
        {
            selecetedScaleType = scaleType.Major;
            SetScaleData();
        }

        private void NaturalMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScaleType = scaleType.NaturalMinor;
            SetScaleData();
        }

        private void MelodicMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScaleType = scaleType.MelodicMinor;
            SetScaleData();
        }

        private void HarmonicMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScaleType = scaleType.HarmonicMinor;
            SetScaleData();
        }

        private void MajorLabel_MouseHover(object sender, EventArgs e)
        {
            MajorLabel.Cursor = Cursors.Hand;
        }

        private void NaturalMinorLabel_MouseHover(object sender, EventArgs e)
        {
            NaturalMinorLabel.Cursor = Cursors.Hand;
        }

        private void MelodicMinorLabel_MouseHover(object sender, EventArgs e)
        {
            MelodicMinorLabel.Cursor = Cursors.Hand;
        }

        private void HarmonicMinorLabel_MouseHover(object sender, EventArgs e)
        {
            HarmonicMinorLabel.Cursor = Cursors.Hand;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();
        }
        //Write the values of the currently displayed scale to a file in the same directory as the executable
        private void writeFile()
        {
            FileStream outFile = new FileStream("scale.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine(NameLabel.Text);
            writer.WriteLine(NotesLabel.Text);
            writer.WriteLine(RelativeLabel.Text + " " + RelativeTextLabel.Text);
            writer.WriteLine();
            writer.WriteLine("I: " + ILabel.Text);
            writer.WriteLine("II: " + IILabel.Text);
            writer.WriteLine("III: " + IIILabel.Text);
            writer.WriteLine("VI: " + IVLabel.Text);
            writer.WriteLine("V: " + VLabel.Text);
            writer.WriteLine("VI: " + VILabel.Text);
            writer.WriteLine("VII: " + VIILabel.Text);
            writer.WriteLine();
            writer.Close();
            outFile.Close();
        }

        private void saveCurrentScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeFile();
            ErrorForm error = new ErrorForm();
            error.Message = "The file has been saved in the same directory as the program executable";
            error.ShowDialog();
        }
        //Splash screen form loading
        public void Splash()
        {
            Application.Run(new SplashForm());
        }
    }
}
