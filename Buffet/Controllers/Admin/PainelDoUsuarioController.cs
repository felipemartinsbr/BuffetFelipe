using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Buffet.Models;
using Buffet.Models.Acesso;
using Buffet.ViewModels.PainelDoUsuario;

namespace Buffet.Controllers.Admin
{
    public class PainelDoUsuarioController : Controller
    {
        private readonly AcessoService _acessoService;
        
        public PainelDoUsuarioController(AcessoService acessoService)
        {
            _acessoService = acessoService;
        }

        public IActionResult Index()
        {
            //Criar um viewModel para conter a lista de dados do usuáerio a ser exibida
            var viewModel = new IndexViewModel();
            
            //Obter o bojeto da entidades do tipo Usuários
            var user = _acessoService.GetUser();
            
            //Processar a lista de entidades para coletar para a ViewModel apenas as informações necessárias
            
            
            
            //Retornar a view junto com a viewModel
            return View(viewModel);
        }
    }
}