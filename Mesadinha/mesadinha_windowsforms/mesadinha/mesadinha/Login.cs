using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using System.Data;

namespace mesadinha
{
    class Login
    {
        public string Usuario;
        public bool Validate(string Email, string Password)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select * from usuario where senha = '{0}' and email = '{1}'", Password, Email);

            DataTable resultado = bd.ConsultarTabela(sql);

            if (resultado.Rows.Count > 0)
            {
                Usuario = resultado.Rows[0]["nome"].ToString();
                Session NewSession = new Session();
                Session.Id = resultado.Rows[0]["id"].ToString();
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
