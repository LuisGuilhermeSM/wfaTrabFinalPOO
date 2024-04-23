using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabFinalPOO
{
    internal class StringConexao
    {

        private string server_name = "localhost";
        private string port =        "5432";
        private string userName = "postgres";
        private string password = "spidy123";
        private string dataBaseName = "bdTrabFinalPOO";

        public string StringParaConexao()
        {
            string con;

            con = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}; Database = {4};",
                server_name, port, userName, password, dataBaseName);

            return con;
        }

    }
}
