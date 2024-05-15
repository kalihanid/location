using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location
{
    public partial class Voiture : Form
    {
        Fonctions Con;
        public Voiture()
        {
            InitializeComponent();
            Con = new Fonctions();
            AfficherVoiture();
        }
        private void AfficherVoiture()
        {
            string Requete = "select * from visualtable ";
            Voitureliste.DataSource = Con.RecupererData(Requete);

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void enregistrertb_Click(object sender, EventArgs e)
        {

        }

        private void Voiture_Load(object sender, EventArgs e)
        {

        }
        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            if ( plaquetb.Text == "" || modeletb.Text == "" || marquetb.SelectedIndex == -1  || prixtb.Text == "" || statuttb.SelectedIndex == -1 )
            {
                MessageBox.Show("Information Incomplete !!");
                
            }else
            {
                try
                {
                    string plaque = plaquetb.Text;
                    string marque = marquetb.SelectedItem.ToString();
                    string modele = modeletb.Text;
                    string statut = statuttb.SelectedItem.ToString();
                    int prix = Convert.ToInt32(prixtb.Text);
                    string Req = "insert into visualtable values ( '{0}', '{1}', '{2}', '{3}', '{4}')";
                Req = string.Format(Req, plaque, marque, modele, statut, prix);
                    Con.EnvoyerData(Req);
                    AfficherVoiture();
                    MessageBox.Show(" vehicule enregistre !!");
                    marquetb.SelectedIndex = -1;
                    modeletb.Text = "";
                    plaquetb.Text = "";
                    prixtb.Text = "";
                    statuttb.SelectedIndex = -1;

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
               

            }
                    }
     
    }
}
 