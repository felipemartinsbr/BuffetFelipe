using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Buffet.Models.Acesso
{
    public class AcessoService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AcessoService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task AutenticarUsuario(string username, string senha)
        {
            var resultado = await _signInManager.PasswordSignInAsync(username, senha, false, false);
            
            if (!resultado.Succeeded)
            {
                throw new Exception("Usuário ou senha inválidos");
            }
        }
        public async Task RegistrarUsuario(string email, string senha)
        {
            var novoUsuario = new Usuario()
            {
                UserName = email,
                Email = email
            };

            var resultado = await _userManager.CreateAsync(novoUsuario, senha);

            
            if (!resultado.Succeeded)
            {
                throw new CadastrarUsuarioException(resultado.Errors);
            }
            
        }
    }
}