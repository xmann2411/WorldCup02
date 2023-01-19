using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCLibrary;

namespace WindowsFormsApp
{
    public partial class PostavkeForma : Form
    {
        public List<string> postavke = new List<string>();

        public PostavkeForma()
        {
            InitializeComponent();

            rbEngleski.CheckedChanged += new EventHandler(rbJezik_CheckedChanged);
            rbHrvatski.CheckedChanged += new EventHandler(rbJezik_CheckedChanged);
            rbMuski.CheckedChanged += new EventHandler(rbTim_CheckedChanged);
            rbZenski.CheckedChanged += new EventHandler(rbTim_CheckedChanged);


            if (WCPostavke.DatotekaPostoji())
            {
                postavke = WCPostavke.UcitajPostavke();

                //  jezik
                if (postavke[0] == "HR")
                {
                    rbHrvatski.Enabled = true;
                }
                else
                {
                    rbEngleski.Enabled = true;
                }

                //  spol
                if (postavke[1] == "MEN")
                {
                    rbMuski.Enabled = true;
                }
                else
                {
                    rbZenski.Enabled= true;
                }
            }
            else
            {
                //  inicijalne vrijednosti
                postavke.Clear();
                postavke.Add("HR");
                rbHrvatski.Checked = true;
                postavke.Add("MEN");
                rbMuski.Checked = true;
            };

        }

        private void rbTim_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rbMuski.Checked)
            {
                postavke[1] = "MEN";
            }
            else if (rbZenski.Checked)
            {
                postavke[1] = "WOMEN";
            }
        }

        private void rbJezik_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rbHrvatski.Checked)
            {
                postavke[0] = "HR";
            }
            else if (rbEngleski.Checked)
            {
                postavke[0] = "EN";
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnSpremi;
        }

        private void Postavke_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    SpremiPostavke();
                    break;

                default:
                    break;
            }
        }

        private void SpremiPostavke()
        {
            WCPostavke.SpremiPostavke(postavke);
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiPostavke();
        }
    }
}
