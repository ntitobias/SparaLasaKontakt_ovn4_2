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

                //Skriv en kontakt i taget
                foreach (Kontakt k in lbxKontakter.Items)
                {
                    //Skriv en rad text i taget.
                    skrivare.WriteLine(k.Förnamn);
                    skrivare.WriteLine(k.Efternamn);
                    skrivare.WriteLine(k.Epost);
                    skrivare.WriteLine(k.Telefonnr);
                }

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
                //Rensa listboxen
                lbxKontakter.Items.Clear();

                //Öppna ström
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);

                //Skapa läsare
                StreamReader läsare = new StreamReader(inStröm);

                //Läs en kontakt i taget.
                string förnamn = läsare.ReadLine();
                while (förnamn != null)
                {
                    Kontakt k = new Kontakt(förnamn, läsare.ReadLine(), läsare.ReadLine(), läsare.ReadLine());
                    lbxKontakter.Items.Add(k);

                    //Kolla om det finns en ny kontakt
                    förnamn = läsare.ReadLine();
                }

                //Stäng filen
                läsare.Dispose();
            }
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            //Skapa kontakt
            Kontakt k = new Kontakt(tbxFörnamn.Text, tbxEfternamn.Text, tbxEpost.Text, tbxTelefonnummer.Text);

            //Lägg till kontakt i listboxen
            lbxKontakter.Items.Add(k);
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            // Ta bort den valda kontakten
            lbxKontakter.Items.RemoveAt(lbxKontakter.SelectedIndex);
            
        }

        private void lbxKontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxKontakter.SelectedItem != null)
            {
                // Gör ett objekt av den valda kontakten
                Kontakt k = lbxKontakter.SelectedItem as Kontakt;
                //Skriv de olika delarna av kontakten i respektive textbox
                tbxFörnamn.Text = k.Förnamn;
                tbxEfternamn.Text = k.Efternamn;
                tbxEpost.Text = k.Epost;
                tbxTelefonnummer.Text = k.Telefonnr;
            }
            else
            {
                //Skriv de olika delarna av kontakten i respektive textbox
                tbxFörnamn.Text = "";
                tbxEfternamn.Text = "";
                tbxEpost.Text = "";
                tbxTelefonnummer.Text = "";
            }

        }
    }
}
