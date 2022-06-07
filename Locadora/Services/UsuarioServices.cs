using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.Services
{
    public class UsuarioServices
    {

        public Usuario CadastrarUsuario(UsuarioViewModel usuarioRecebeido)
        {
            Usuario usuario = new Usuario(usuarioRecebeido);
            Armazenamento.Usuarios.Add(usuario);
            return usuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            return Armazenamento.Usuarios;
        }
        public Usuario ObterUsuario(string idRecebido)
        {
            List<Usuario> lista = ListarUsuarios();
            if (lista.Any(u => u.Id.ToString() == idRecebido))
            {
                Usuario usuario = lista.Where(u => u.Id.ToString() == idRecebido).First();
                return usuario;
            }
            return null;
        }
    }
}
