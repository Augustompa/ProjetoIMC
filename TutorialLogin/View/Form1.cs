using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Usuario = txtUsuario.Text;
            lg.Senha = txtSenha.Text;

            if(lg.ValidarLogin(lg.Usuario, lg.Senha))
            {
                Principal pl = new Principal();
                pl.Show();
                
            }
            
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();

        }

       
    }
}
