using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Consulter_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            string sqlClub = "SELECT NUM_LICENCE, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, ADR_VILLE_MEMBRE " +
                "FROM `membre` " +
                "ORDER BY `membre`.`DATE_NAISSANCE`, `NOM_MEMBRE`";
            MySqlCommand cmdMembre = new MySqlCommand(sqlClub, conn);
            MySqlDataReader readerMembre = cmdMembre.ExecuteReader();

            while (readerMembre.Read())
            {
                string NUM_LICENCE = (readerMembre["NUM_LICENCE"].ToString());
                string NOM_MEMBRE = (readerMembre["NOM_MEMBRE"].ToString());
                string PRENOM_MEMBRE = (readerMembre["PRENOM_MEMBRE"].ToString());
                string DATE_NAISSANCE = (readerMembre["DATE_NAISSANCE"].ToString());
                
                string ADR_RUE_MEMBRE = (readerMembre["ADR_RUE_MEMBRE"].ToString());
                string ADR_VILLE_MEMBRE = (readerMembre["ADR_VILLE_MEMBRE"].ToString());
                
                
                dataGridView1.Rows.Add(NUM_LICENCE, NOM_MEMBRE, PRENOM_MEMBRE, DATE_NAISSANCE, ADR_RUE_MEMBRE, ADR_VILLE_MEMBRE);

            }
            conn.Close();
        }
    }
}
