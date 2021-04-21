using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-F5RLTTT; initial catalog=inlock_games_manha; user Id=sa; pwd=L@iane/j13";
        public UsuarioDomain BuscarPorEmailSenha(string email, string senha, int idTipoUsuario)
        {
            // Define a conexão con passando a string de conexao
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT idUsuario, email, senha, idTipoUsuario FROM usuarios WHERE email = @email AND senha = @senha; ";

                // comando cmd  com a query e a conexao
                using (SqlCommand cmd = new SqlCommand(querySelect,con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@idTipoUsuario", idTipoUsuario);

                    con.Open();

                    // executa o comando e armazena os dados no objeto rdr
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuarioBuscado = new UsuarioDomain
                        {
                            // atribuindo propiedades
                            idUsuario = Convert.ToInt32(rdr["idUsuario"]),
                            email = rdr["email"].ToString(),
                            senha = rdr ["senha"].ToString(),
                            idTipoUsuario   = Convert.ToInt32(rdr["idTipoUsuario"])
                        };

                        // usuario buscado
                        return usuarioBuscado;
                    }

                    // CASO N O ENCONTRE email e senha
                    return null;

                }
            }
        }
    }
}
