using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace mesadinha
{
    class ConexaoBD
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            conexao = new MySqlConnection("persist security info = false;server=localhost;database=mesadinha;uid=root;pwd=;");
            conexao.Open();
        }

        // Não sei pq fiz alterar tabela e alterar dados (são iguais) mas já que usei as duas e vi agora então deixa p/ lá mesmo.
        public void AlterarTabela(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabela(string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }

        public int AlterarDados(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

