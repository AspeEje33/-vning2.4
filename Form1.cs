using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Figur
        {
            public float bredd;
            public float höjd;

            public Figur(float bredd, float höjd)
            {
                this.bredd = bredd;
                this.höjd = höjd;
            }
        }

        class Triangel : Figur
        {
            //en konstruktor för vad en triangel är.
            public Triangel(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            //En metod för hur triangels area ska beräknas.
            public float BeräknaArea()
            {
                return (bredd * höjd) / 2;
            }

            //En metod för vad som ska skrivas i listboxen.
            public override string ToString()
            {
                return "Triangel: " + bredd + " x " + höjd;
            }
        }

        class Cirkel : Figur
        {
            //en konstruktor för vad en cirkel är.
            public Cirkel(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            //En metod för hur triangels area ska beräknas.
            public float BeräknaArea()
            {
                return bredd * (float)Math.PI;
            }

            public override string ToString()
            {
                return "Cirkel: " + bredd + " x " + bredd;
            }
        }

        class Linje : Figur
        {
            public Linje(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            public override string ToString()
            {
                return "Linje: " + bredd + " x " + höjd;
            }
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Triangel triangel = new Triangel(bredd, höjd);
                lbxFigur.Items.Add(triangel);
            }
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Cirkel cirkel = new Cirkel(bredd, höjd);
                lbxFigur.Items.Add(cirkel);
            }
        }

        private void btnLinje_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Linje linje = new Linje(bredd, höjd);
                lbxFigur.Items.Add(linje);
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            float summa = 0;

            foreach (Figur f in lbxFigur.Items)
            {

                if (f is Triangel)
                {
                    summa += (f as Triangel).BeräknaArea();
                }
                else if (f is Cirkel)
                {
                    summa += (f as Cirkel).BeräknaArea();
                }

            }

            tbxArea.Text = Math.Round(summa, 2).ToString() + " Kvadratmeter";
        }
    }
}
