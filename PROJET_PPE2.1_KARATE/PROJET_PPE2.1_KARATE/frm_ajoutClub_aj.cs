using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class frm_ajoutClub_aj : Form
    {
        public frm_ajoutClub_aj()
        {
            InitializeComponent();
        }

        private void frm_ajoutClub_aj_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            string sql = "INSERT INTO club SELECT MAX(NUM_CLUB) +1, @Nom, @Adresse, @CodePostal, @Ville FROM club;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nom", Txt_Nom.Text );
            cmd.Parameters.AddWithValue("@Adresse", Txt_Adresse.Text);
            cmd.Parameters.AddWithValue("@Ville", Txt_Ville.Text);
            cmd.Parameters.AddWithValue("@CodePostal", Txt_Cp.Text);
            cmd.ExecuteNonQuery();
            Txt_Nom.Text = "";
            Txt_Adresse.Text = "";
            Txt_Ville.Text = "";
            Txt_Cp.Text = "";
            conn.Close();
    
            
        }

        private void Option_Click(object sender, EventArgs e)
        {
            Form modifier = new frm_club_modif_suppr();
            modifier.ShowDialog();
        }


        private void Txt_Adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consulter_Click(object sender, EventArgs e)
        {
            Form consulter = new Consulter();
            consulter.ShowDialog();
        }
    }
}
