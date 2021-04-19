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
        private readonly ClienteService _clienteService;

        public HomeController(
            ILogger<HomeController> logger,
            ClienteService clienteService
            
            )
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
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
            
            // Trazer lista de clientes do banco de dados
            var clientesDoBanco = _clienteService.obterClientes();
            foreach (var clienteEntity in clientesDoBanco) {
                viewmodel.Clientes.Add(new Cliente()
                            {
                                Id = clienteEntity.Id.ToString() ,
                                Nome = clienteEntity.Nome
                            });
            }
            
            
            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
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
