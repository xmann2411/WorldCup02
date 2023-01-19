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
using WCLibrary.Modeli;

namespace WindowsFormsApp
{
    public partial class GlavnaForma : Form
    {
        private  List<string> postavke = new List<string>();
        private List<Team> timovi;

        public GlavnaForma()
        {
            InitializeComponent();

            if (!WCPostavke.DatotekaPostoji())
            {
                var postavkeForma = new PostavkeForma();
                postavkeForma.ShowDialog();
                postavke.Clear();
                postavke.Add(postavkeForma.postavke[0]); // jezik
                postavke.Add(postavkeForma.postavke[1]); // spol tima
            };

            UcitajTimove();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        public async void UcitajTimove()
        {
            try
            {
                toolStripStatusLabel.Text = "Učitavam podatke";
                timovi = await WCPodaci.DohvatiTimove("MAN");
            }
            catch (Exception)
            {

                throw;
            }
            
            comboBoxTim.BeginInvoke(
                (Action)(() =>
                {
                    foreach (var tim in timovi)
                    {
                        comboBoxTim.Items.Add(tim.NazivTima());
                    }
                }));
            
            toolStripStatusLabel.Text = "";
        }
    }
}
