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

        MySqlConnection Sqlcon = null;
        private string  Strcon = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";
        private string Strsql = string.Empty;
        MySqlCommand cmd;
        MySqlDataReader dr;
       


        private void brnCadastrar_Click(object sender, EventArgs e)
        {

            cmd = new MySqlCommand(Strcon, Sqlcon);



            string Strsql = "insert into (id,email,senha,nome) values (@id,@email,@senha,@nome)";
            Sqlcon = new MySqlConnection(Strcon);
            MySqlCommand con = new MySqlCommand(Strsql, Sqlcon);



            con.Parameters.AddWithValue("@id", txtID.Text);
            con.Parameters.AddWithValue("@email", txtUsuario.Text);
            con.Parameters.AddWithValue("@senha", txtSenha.Text);
            con.Parameters.AddWithValue("@nome", txtNome.Text);
            

            try
            {

                Sqlcon.Open();
                MessageBox.Show("Conexao aberta");
                con.ExecuteNonQuery();
                

                MessageBox.Show("Usuario cadastrado com sucesso!");

                Principal pr = new Principal();

                pr.Show();


            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar usuário");
                erro.GetBaseException();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
