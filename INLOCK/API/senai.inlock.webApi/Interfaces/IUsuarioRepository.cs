using senai.inlock.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        
        /// <summary>
        /// valida o usuario
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="senha">senha</param>
        /// <returns>objeto buscado</returns>
        UsuarioDomain BuscarPorEmailSenha(string email, string senha, int idTipoUsuario);
    }
}
