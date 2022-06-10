using Locadora.API.Services;
using Locadora.Models;
using Locadora.Repository;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {

        private UsuarioServices _usuarioServices = new UsuarioServices();

        [HttpPost]
        public ActionResult CadastrarUsuario(
            [FromBody] UsuarioViewModel usuarioRecebido)
        {
            string nomeDoUsuario = usuarioRecebido.Nome;
            int idadeDoUsuario = usuarioRecebido.Idade;

            if (usuarioRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum usuário.");
            }

            if (string.IsNullOrEmpty(nomeDoUsuario))
            {
                return BadRequest("Nome de usuário não informado.");
            }

            if (idadeDoUsuario < 18)
            {
                return BadRequest("Não é permitido o cadastro de pessoas com menores de 18 anos.");
            }

            Usuario objetoCriado = _usuarioServices.CadastrarUsuario(usuarioRecebido);
            return Created("usuarios", objetoCriado);
        }

        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Usuario> listaUsuario =
                _usuarioServices.ListarUsuarios();
            return listaUsuario;
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
