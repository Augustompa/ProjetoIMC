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
       string usuario;
       string contraseña;

       #endregion

       #region"Propiedades"

       public string Usuario
       {
           set { usuario = value; }
           get { return usuario; }
       }

       public string Contraseña
       {
           set { contraseña = value; }
           get { return contraseña; }
       }

       #endregion   

       #region"funciones"
       public bool ValidarLogin(string u, string c)
       {

           string cadenaconexion = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";
           MySqlConnection con = new MySqlConnection(cadenaconexion);
           con.Open();
           MySqlCommand cmd;
           MySqlDataReader dr;

           string sql = "SELECT * FROM tblLogin WHERE email = '"+u+"' and senha ='"+c+ "' ";
           cmd = new MySqlCommand(sql, con);
           dr = cmd.ExecuteReader();

           dr.Read();

           if (dr.HasRows)
           {
            
               return true;

           }
           else
           {
               MessageBox.Show("Usuario y/o contraseña incorrecto");

               return false;
           }

           return false;






       }
       #endregion
   }
}
