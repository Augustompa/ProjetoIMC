using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TutorialLogin
{
    class Connection
    {

        public void SqlConnection()
        {
            string cadeiaconexao = "Server=localhost;Database=bdprojeto; Uid=root;Pwd=;port=3306;";
            MySqlConnection con = new MySqlConnection(cadeiaconexao);
            con.Open();
            MySqlCommand cmd;
            MySqlDataReader dr;
            

    }
    }


}
