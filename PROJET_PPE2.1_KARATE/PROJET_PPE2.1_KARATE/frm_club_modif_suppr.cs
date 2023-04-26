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
    public partial class frm_club_modif_suppr : Form
    {
        int Club_Id;
        public frm_club_modif_suppr()
        {
            InitializeComponent();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            string sqlClub = "DELETE FROM club WHERE NUM_CLUB = @Num;" +
                "DELETE FROM competition WHERE NUM_CLUB = @Num;"+
                "DELETE FROM membre WHERE NUM_CLUB = @Num;";

            MySqlCommand cmdClub = new MySqlCommand(sqlClub, conn);
            string NUM_CLUB = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmdClub.Parameters.AddWithValue("@Num", NUM_CLUB);
            string NOM_CLUB = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string ADR_RUE_CLUB = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string CODE_POST_CLUB = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string ADR_VILLE_CLUB = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmdClub.ExecuteNonQuery();
           
            dataGridView1.Rows.Clear();
           
             sqlClub = "SELECT NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB FROM club ;";
             cmdClub = new MySqlCommand(sqlClub, conn);
            MySqlDataReader readerClub = cmdClub.ExecuteReader();

            while (readerClub.Read())
            {
                 NUM_CLUB = (readerClub["NUM_CLUB"].ToString());
                 NOM_CLUB = (readerClub["NOM_CLUB"].ToString());
                 ADR_RUE_CLUB = (readerClub["ADR_RUE_CLUB"].ToString());
                 CODE_POST_CLUB = (readerClub["CODE_POST_CLUB"].ToString());
                 ADR_VILLE_CLUB = (readerClub["ADR_VILLE_CLUB"].ToString());

                dataGridView1.Rows.Add(NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB);
            }
            conn.Close();
           
        }

        private void frm_club_modif_suppr_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            string sqlClub = "SELECT NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB FROM club ;";
            MySqlCommand cmdClub = new MySqlCommand(sqlClub, conn);
            MySqlDataReader readerClub = cmdClub.ExecuteReader();

            while (readerClub.Read())
            {
                string NUM_CLUB = (readerClub["NUM_CLUB"].ToString());
                string NOM_CLUB = (readerClub["NOM_CLUB"].ToString());
                string ADR_RUE_CLUB = (readerClub["ADR_RUE_CLUB"].ToString());
                string CODE_POST_CLUB = (readerClub["CODE_POST_CLUB"].ToString());
                string ADR_VILLE_CLUB = (readerClub["ADR_VILLE_CLUB"].ToString());

                dataGridView1.Rows.Add(NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB);
            }
            conn.Close();
        }

        private void Bnt_Modifier_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            string sqlClub = "UPDATE club SET NOM_CLUB='" + Nom.Text + "' , ADR_RUE_CLUB='" + Adresse.Text + "' , CODE_POST_CLUB='" + CodePostal.Text + "' , ADR_VILLE_CLUB='" + Ville.Text + "'WHERE NUM_CLUB = @Num;";
            MySqlCommand cmdClub = new MySqlCommand(sqlClub, conn);
            string NUM_CLUB = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmdClub.Parameters.AddWithValue("@Num", NUM_CLUB);
            string NOM_CLUB = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string ADR_RUE_CLUB = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string CODE_POST_CLUB = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string ADR_VILLE_CLUB = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmdClub.ExecuteNonQuery();

            dataGridView1.Rows.Clear();
             sqlClub = "SELECT NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB FROM club ;";
             cmdClub = new MySqlCommand(sqlClub, conn);
            MySqlDataReader readerClub = cmdClub.ExecuteReader();

            while (readerClub.Read())
            {
                 NUM_CLUB = (readerClub["NUM_CLUB"].ToString());
                 NOM_CLUB = (readerClub["NOM_CLUB"].ToString());
                 ADR_RUE_CLUB = (readerClub["ADR_RUE_CLUB"].ToString());
                 CODE_POST_CLUB = (readerClub["CODE_POST_CLUB"].ToString());
                 ADR_VILLE_CLUB = (readerClub["ADR_VILLE_CLUB"].ToString());

                dataGridView1.Rows.Add(NUM_CLUB, NOM_CLUB, ADR_RUE_CLUB, CODE_POST_CLUB, ADR_VILLE_CLUB);
            }

            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Club_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Nom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Adresse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                CodePostal.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Ville.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

    }
    }

