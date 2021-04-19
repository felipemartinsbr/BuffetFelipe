using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuffetFelipe.Models;
using BuffetFelipe.Models.Buffet.Cliente;
using BuffetFelipe.ViewModels.Home;

namespace BuffetFelipe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Clientes()
        {
            // Trazer lista de entidade clientes dos erviço de clientes (model)
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.obterClientes();

            //  Criar e popular a viewModel
            var viewModel = new ClientesViewModel();
            foreach (ClienteEntity clienteEntity in listaDeClientes) {
                viewModel.Clientes.Add( new Cliente
                {
                    Nome = clienteEntity.Nome,
                    DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString()
                });
            }
            
             
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}