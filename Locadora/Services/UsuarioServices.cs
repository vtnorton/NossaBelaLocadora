using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;

namespace Locadora.API.Services
{
    public class UsuarioServices
    {
        public Usuario CadastrarUsuario(
            UsuarioViewModel usuarioRecebeido)
        {
            Usuario usuario = 
                new Usuario(usuarioRecebeido);
            Armazenamento.Usuarios.Add(usuario);

            return  usuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            return Armazenamento.Usuarios;
        }
    }
}
