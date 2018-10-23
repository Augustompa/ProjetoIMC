using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TutorialLogin
{
   public  class Login
   {
        #region"atributos"
        private string usuario;
            private string senha;
            private string nome;
            private int id;


       #endregion

       #region"Propiedades"

       public string Usuario
       {
           set { usuario = value; }
           get { return usuario; }
       }

       public string Senha
       {
           set { senha = value; }
           get { return senha; }
       }

        public string Nome
        {
            set { nome = value; }
            get { return senha;}
        }

        public string Id
        {
            set { Id = value;}
            get { return Id;}
        }

       #endregion   

       #region"funcões"
       public bool ValidarLogin(string usuario, string senha)
       {

           string cadeiaconexao = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";
           MySqlConnection con = new MySqlConnection(cadeiaconexao);
           con.Open();
           MySqlCommand cmd;
           MySqlDataReader dr;
           

           string sql = "SELECT * FROM tblusuario WHERE email = '"+usuario+"' and senha ='"+senha+ "' ";
           cmd = new MySqlCommand(sql, con);
           dr = cmd.ExecuteReader();

           dr.Read();

           if (dr.HasRows)
           {
            
               return true;
              

           }

            
           else
           {
               MessageBox.Show("Usuario ou senha incorretos");

               return false;
           }

       

                                      
       }

       
       #endregion
   }
}
