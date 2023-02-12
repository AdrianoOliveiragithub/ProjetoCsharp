
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace SAGI        //baleia
{
    class Conexao
    {

        public int x=10;
        
      public MySqlConnection Mcon = new MySqlConnection("Persist Security Info = False; server = localhost;database = teste ;uid = root; pwd= ");
        public void conectar()
        {
            Mcon.Open();
        }

        public void desconectar()
        {
            Mcon.Close();
        }

        
    }
}

