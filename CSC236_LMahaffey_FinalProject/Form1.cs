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
    public partial class Form1 : Form
    {
        private enum scaleType
        {
            Major,
            NaturalMinor,
            MelodicMinor,
            HarmonicMinor,
            PentatonicMajor,
            PentatonicMinor
        };
        private string key = "C";
        private scaleType selecetedScale = 0;
        public Scale scale;
        public Form1()
        {
            InitializeComponent();
            SetScaledata();
        }

        void SetScaledata()
        {
            calculateScale();
            NotesLabel.Text = scale.GetScaleAsString();
            NameLabel.Text = key + " " + selecetedScale;
            ILabel.Text = scale.GetChordAsString(scale.I);
            IILabel.Text = scale.GetChordAsString(scale.II);
            IIILabel.Text = scale.GetChordAsString(scale.III);
            IVLabel.Text = scale.GetChordAsString(scale.IV);
            VLabel.Text = scale.GetChordAsString(scale.V);
            VILabel.Text = scale.GetChordAsString(scale.VI);
            VIILabel.Text = scale.GetChordAsString(scale.VII);
        }

        private void calculateScale()
        {
            switch (selecetedScale)
            {
                case scaleType.Major:
                    scale = new MajorScale(key);
                    break;
                case scaleType.NaturalMinor:
                    scale = new NatualMinorScale(key);
                    break;
                case scaleType.MelodicMinor:
                    scale = new HarmonicMinorScale(key);
                    break;
                case scaleType.HarmonicMinor:
                    scale = new MelodicMinorScale(key);
                    break;
                case scaleType.PentatonicMajor:
                    scale = new PentatonicMajorScale(key);
                    break;
                case scaleType.PentatonicMinor:
                    scale = new PentatonicMinorScale(key);
                    break;
            }
        }
        private void GsAfButton_Click(object sender, EventArgs e)
        {
            key = "Af";
            SetScaledata();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            key = "A";
            SetScaledata();
        }

        private void AsBfButton_Click(object sender, EventArgs e)
        {
            key = "Bf";
            SetScaledata();
        }

        private void B_Click(object sender, EventArgs e)
        {
            key = "B";
            SetScaledata();
        }

        private void C_Click(object sender, EventArgs e)
        {
            key = "C";
            SetScaledata();
        }

        private void CsDf_Click(object sender, EventArgs e)
        {
            key = "Df";
            SetScaledata();
        }

        private void D_Click(object sender, EventArgs e)
        {
            key = "D";
            SetScaledata();
        }

        private void DsEf_Click(object sender, EventArgs e)
        {
            key = "Ef";
            SetScaledata();
        }

        private void E_Click(object sender, EventArgs e)
        {
            key = "E";
            SetScaledata();
        }

        private void F_Click(object sender, EventArgs e)
        {
            key = "F";
            SetScaledata();
        }

        private void FsGfButton_Click(object sender, EventArgs e)
        {
            key = "Fs";
            SetScaledata();
        }

        private void G_Click(object sender, EventArgs e)
        {
            key = "G";
            SetScaledata();
        }

        private void MajorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.Major;
            SetScaledata();
        }

        private void NaturalMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.NaturalMinor;
            SetScaledata();
        }

        private void MelodicMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.MelodicMinor;
            SetScaledata();
        }

        private void HarmonicMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.HarmonicMinor;
            SetScaledata();
        }

        private void PentatonicMajorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.PentatonicMinor;
            SetScaledata();
        }

        private void PentatonicMinorLabel_Click(object sender, EventArgs e)
        {
            selecetedScale = scaleType.PentatonicMajor;
            SetScaledata();
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

        private void PentatonicMajorLabel_MouseHover(object sender, EventArgs e)
        {
            PentatonicMajorLabel.Cursor = Cursors.Hand;
        }

        private void PentatonicMinorLabel_MouseHover(object sender, EventArgs e)
        {
            PentatonicMinorLabel.Cursor = Cursors.Hand;
        }
    }
}
