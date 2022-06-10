using Locadora.Models;
using Locadora.Repository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Services
{
    public class UsuarioServices
    {
        public Usuario CadastrarUsuario(
            UsuarioViewModel usuarioRecebido)
        {
            Usuario usuario = new Usuario(usuarioRecebido);
            Armazenamento.Usuarios.Add(usuario);

            return usuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            return Armazenamento.Usuarios
                .OrderBy(usuario => usuario.Nome)
                .ThenBy(Usuario => Usuario.Idade)
                .ToList();
            // pesquisar sobre os termos utilizados de BD
        }

        public Usuario ObterUsuario(string idRecebido)
        {
            List<Usuario> listaUsuario = ListarUsuarios();
            if (listaUsuario.Any(u => u.IdUsuario.ToString() == idRecebido))
            {
                Usuario usuario = listaUsuario
                   .Where(u => u.IdUsuario.ToString() == idRecebido)
                   .First();
                return usuario;
            }

            return null; // usar isso para evitar erro se houver lista vazia.
        }
    }
}
