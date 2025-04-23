using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrutura.Repository
{
    public class UserRepository
    {
        private readonly string connectionString = "User Id=RM98680;Password=271204;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";
        
        public bool validateUser(string usuario, string senha)
        {
            using (OracleConnection conexao = new OracleConnection(connectionString))
            {
                conexao.Open();
                string query = "select count(1) from Usuarios_FIAP where NomeUsuario = '" + usuario + "' and Senha = '" + senha + "'";
                OracleCommand comando = new OracleCommand(query, conexao);

                object retorno = comando.ExecuteScalar();

                if (int.Parse(retorno.ToString()) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
