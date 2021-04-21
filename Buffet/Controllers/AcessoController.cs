using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Buffet.Models.Acesso;
using Buffet.Models.Buffet.Cliente;
using Buffet.RequestModels;
using Buffet.ViewModels.Acesso;
using Microsoft.AspNetCore.Mvc;


namespace Buffet.Controllers
{
    public class AcessoController : Controller
    {
        private readonly AcessoService _acessoService;

        public AcessoController(AcessoService acessoService)
        {
            _acessoService = acessoService;
        }
        
        [HttpGet]public IActionResult Login()
        {
            var viewmodel = new LoginViewModel();

            viewmodel.MensagemLogin = (string) TempData["msg-login"];
            //viewmodel.ErrosLogin = (string[]) TempData["erros-login"];
            
            return View(viewmodel);
        }

        [HttpPost]
        public  async Task<RedirectToActionResult> Login(AcessoLoginRequestModel request)
        {
            var userEmail = request.Email;
            var senha = request.Senha;
            
            if (userEmail == null)
            {
                TempData["erros-login"] = "Por favor informe o e-mail";
                return RedirectToAction("Login");
            }

            try
            {
                await _acessoService.AutenticarUsuario(userEmail, senha);
                TempData["msg-login"] = "Login realizado com sucesso";
                return RedirectToAction("Supervisao", "Admin");
                
            }
            catch (CadastrarUsuarioException exception)
            {
                var listaErros = new List<string>();

                foreach (var identityError in exception.Erros)
                {
                    listaErros.Add(identityError.Description);
                }

                TempData["erros-login"] = listaErros;
                return RedirectToAction("Login");
            
            }
        }
        public IActionResult RecuperarConta()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var viewmodel = new CadastrarViewModel();

            viewmodel.Mensagem = (string) TempData["msg-cadastro"];
            viewmodel.ErrosCadastro = (string[]) TempData["erros-cadastro"];
            
            return View(viewmodel);
        }
        
        [HttpPost]
        public async Task <RedirectToActionResult> Cadastrar(AcessoCadastrarRequestModel request)
        {
            var email = request.Email;
            var senha = request.Senha;
            var senhaConfirmacao = request.SenhaConfirmacao;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Por favor informe o e-mail";
                return RedirectToAction("Cadastrar");
            }

            try
            {
                await _acessoService.RegistrarUsuario(email, senha);
                TempData["msg-cadastro"] = "Cadastro realizado com sucesso, faça o login";
                return RedirectToAction("Login");
                
            }
            catch (CadastrarUsuarioException exception)
            {
                var listaErros = new List<string>();

                foreach (var identityError in exception.Erros)
                {
                    listaErros.Add(identityError.Description);
                }

                TempData["erros-cadastro"] = listaErros;
                return RedirectToAction("Cadastrar");
            
            }
            
            
        }
    }
}