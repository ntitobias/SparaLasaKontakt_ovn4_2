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

namespace SparaLasaKontakt_ovn4_2
{
    public partial class frmEnKontakt : Form
    {
        public frmEnKontakt()
        {
            InitializeComponent();
        }

        private void btnSparaSom_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgSparaFil.ShowDialog();

            if(resultat == DialogResult.OK)
            {
                //Öppna ström
                FileStream utStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                //Skapa skrivare
                StreamWriter skrivare = new StreamWriter(utStröm);

                //Skriv en rad text i taget.
                skrivare.WriteLine(tbxFörnamn.Text);
                skrivare.WriteLine(tbxEfternamn.Text);
                skrivare.WriteLine(tbxEpost.Text);
                skrivare.WriteLine(tbxTelefonnummer.Text);

                //Stäng filen
                skrivare.Dispose();
            }
        }

        private void btnÖppna_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn för öppning
            DialogResult resultat = dlgÖppnaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //Öppna ström
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);

                //Skapa läsare
                StreamReader läsare = new StreamReader(inStröm);

                //Läs en rad text i taget.
                tbxFörnamn.Text = läsare.ReadLine();
                tbxEfternamn.Text = läsare.ReadLine();
                tbxEpost.Text = läsare.ReadLine();
                tbxTelefonnummer.Text = läsare.ReadLine();

                //Stäng filen
                läsare.Dispose();
            }
        }
    }
}
