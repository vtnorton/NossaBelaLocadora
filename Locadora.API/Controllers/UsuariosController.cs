using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        
        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
      
            List<Usuario> listaUsuario = 
                Armazenamento.Usuarios;
            return Armazenamento.Usuarios.OrderBy(usuario => usuario.Nome).ThenBy(usuario => usuario.Idade)
                .ToList();
        }
        private UsuarioServices _usuarioServices = new UsuarioServices();

        [HttpPost]
        public ActionResult CadastrarUsuario([FromBody] UsuarioViewModel usuarioRecebido)
        {
            string nomeDoUsuario = usuarioRecebido.Nome;
            if (string.IsNullOrEmpty(nomeDoUsuario))
            {
                return BadRequest("Não possuí nome do Usuário");
            }
            if (usuarioRecebido.Idade < 18)
            {
                return BadRequest("Não é permitido cadastro de pessoas menores");
            }

            Usuario objetoCriado = _usuarioServices.CadastrarUsuario(usuarioRecebido);
            return Created("usuarios", objetoCriado);
 
        }

        [HttpGet("{id}")]
        public IActionResult ObterUsuario(string id)
        {
            Usuario usuario = _usuarioServices.ObterUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

    }
}
