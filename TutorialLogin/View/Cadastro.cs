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


namespace TutorialLogin
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        String connectionString = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";
        bool novo;


        private void BrnCadastrar_Click(object sender, EventArgs e)
        {


            string sql = "INSERT INTO tblusuario (id, email, senha, nome) " + "VALUES ('" + txtID.Text + "', '" + txtUsuario.Text + "', '" + txtSenha.Text + "', '" + txtNome.Text + "')";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }





        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}