using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BuffetFelipe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuffetFelipe.Models;
using BuffetFelipe.Models.Buffet;
using BuffetFelipe.Models.Buffet.Cliente;
using BuffetFelipe.ViewModels.Home;
using BuffetFelipe.ViewModels.Shared;

namespace BuffetFelipe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext _dataBaseContext;

        public HomeController(
            ILogger<HomeController> logger,
            DataBaseContext dataBaseContext
            )
        {
            _logger = logger;
            _dataBaseContext = dataBaseContext;
        }

        public IActionResult Index()
        {
            var novoCliente = new ClienteEntity
            {
                Nome = "Jose" ,
                DataDeNascimento =  new DateTime(),
                Idade = 40
            };
            _dataBaseContext.Clientes.Add(novoCliente);
            _dataBaseContext.SaveChanges();
            
            var todosClientes =_dataBaseContext.Clientes.ToList();

            foreach (ClienteEntity cliente in todosClientes)
            {
                Console.WriteLine(cliente.Nome);
            }
            
            
            
            // 1ª forma de enviar dados para a view
            ViewBag.InformacaoQualquer = "Informação qualquer";
            
            // 2ª forma de enviar dados para a view
            ViewData["informacao"] = "Outra informação";
            
            // 3ª forma de enviar dados para a view
            var viewmodel = new IndexViewModel();
            viewmodel.InformacaoQualquer = "Informação pela View Model";
            viewmodel.Titulo = "Titulo qualquer";

            viewmodel.UsuarioLogado = new Usuario()
            {
                Nome = "Felipe",
                Idade = 31
            };
            return View(viewmodel);
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
                    DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString(),
                    Idade = clienteEntity.Idade
                });
            }
            
             
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        public IActionResult StatusEvento()
        {
            // Acessando um service para obter a lista de status dos eventos
            var listaStatusEventos = new List<StatusEvento>();
            listaStatusEventos.Add(new StatusEvento()
                {
                    Id = 1,
                    Descricao = "Reservado"
                        
                }
            );
            listaStatusEventos.Add(new StatusEvento()
                {
                    Id = 2,
                    Descricao = "Confirmado"
                        
                }
            );
            listaStatusEventos.Add(new StatusEvento()
                {
                    Id = 3,
                    Descricao = "Confirmado"
                        
                }
            );
            
            // Crio a view model
            var viewmodel = new StatusEventoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusEvento statusEvento in listaStatusEventos)
            {
                viewmodel.ListaDeStatus.Add(new Status()
                {
                    Id = statusEvento.Id,
                    Descricao = statusEvento.Descricao,
                });
            }
            return View(viewmodel);
        }
        
        public IActionResult StatusConvidado()
        {
            // Acessando um service para obter a lista de status dos convidados
            var listaStatusConvidado = new List<StatusConvidado>();
            listaStatusConvidado.Add(new StatusConvidado()
                {
                    Id = 1,
                    Descricao = "A confirmar"
                        
                }
            );
            listaStatusConvidado.Add(new StatusConvidado()
                {
                    Id = 2,
                    Descricao = "Confirmado"
                        
                }
            );
            // Crio a view model
            var viewmodel = new StatusConvidadoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusConvidado statusConvidado in listaStatusConvidado)
            {
                viewmodel.ListaDeStatus.Add(new Status()
                {
                    Id = statusConvidado.Id,
                    Descricao = statusConvidado.Descricao
                });
            }
            return View(viewmodel);
        }
        }
    }
