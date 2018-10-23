using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace TutorialLogin
{
    public partial class Principal : Form
    {

        public Principal()
        {
            this.InitializeComponent();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";


            string sql = "SELECT * FROM tblusuario";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();



            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable tblusuario = new DataTable();

            da.Fill(tblusuario);
            dataGridView1.DataSource = tblusuario;
            MySqlDataReader dr = cmd.ExecuteReader();

            int nColunas = dr.FieldCount;


            for (int i = 0; i < nColunas; i++)

            {

                dataGridView1.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
              


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}

