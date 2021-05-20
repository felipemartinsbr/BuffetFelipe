using System;
using System.Collections.Generic;
using System.Diagnostics;
using Buffet.Models.Buffet.Cliente;
using Buffet.RequestModels.Buffet.Cliente;
using Buffet.ViewModels.Buffet;
using Buffet.ViewModels.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Buffet.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;
        private readonly TipoClienteService _tipoClienteService;

        public ClienteController(
            ClienteService clienteService, 
            TipoClienteService tipoClienteService
            )
        {
            _clienteService = clienteService;
            _tipoClienteService = tipoClienteService;
        }

        public IActionResult Index()
        {   
            // Criar uma viewModel para conter a lista de clientes do Buffet a serem exibidos ao usuário
            var viewModel = new IndexViewModel()
            {
                MensagemSucesso = (string) TempData["formMensagemSucesso"],
                MensagemErro = (string) TempData["formMensagemErro"]
            };
            
            // Obter a lista de entidades do tipo Cliente
            var listaDeClientes = _clienteService.ObterTodos();
            
            //Processar a lista de entidades para coletar para a ViewModel apenas as informações necessárias
            foreach (ClienteEntity clienteEntity in listaDeClientes)
            {
            viewModel.Clientes.Add(new Cliente()
            {
                Id = clienteEntity.Id.ToString(),
                Nome = clienteEntity.Nome,
                Email = clienteEntity.Email,
                DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString(),
                Observacoes = clienteEntity.Observaçoes,
                TipoCliente = clienteEntity.TipoCliente.Descricao,
                DataEntrada = clienteEntity.EntradaCliente.ToShortDateString(),
                UltimaModificacao = clienteEntity.UltimaModificacaoCliente.ToShortDateString()
            });
            }
            
            //Retornar a view junto com a ViewModel
            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult Adicionar()
        {
            var viewModel = new AdicionarViewModel()
            {
                FormMensagensErro = (string[]) TempData["formMensagemErro"]
            };

            var tipoCliente = _tipoClienteService.ObterTodos();
            foreach (var tipoClienteEntity in tipoCliente)
            {
                viewModel.TipoClientes.Add(new SelectListItem()
                {
                    Value = tipoClienteEntity.Id.ToString(),
                    Text = tipoClienteEntity.Descricao
                });
            }

            return View(viewModel);
        }

        [HttpPost]
        public RedirectToActionResult Adicionar(AdicionarRequestModel requestModel)
        {
            // Validações e filtros de Dados
            var listaDeErros = requestModel.ValidarEFiltrar();
            if (listaDeErros.Count > 0) {
                TempData["formMensagensErro"] = listaDeErros;

                return RedirectToAction("Adicionar");
            }
            
            // Execuções de Operações
            try {
                _clienteService.Adicionar(requestModel);
                TempData["formMensagemSucesso"] = "Cliente adicionado com sucesso!";

                return RedirectToAction("Index");
            } catch (Exception exception)
            {
                TempData["formMensagensErro"] = new List<string> {exception.Message};

                return RedirectToAction("Adicionar");
            }
        }
        
        public IActionResult Editar()
        {
            return View();
        }
        
        public IActionResult Remover()
        {
            return View();
        }
    }
}