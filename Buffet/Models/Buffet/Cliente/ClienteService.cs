using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;

using Microsoft.EntityFrameworkCore;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DatabaseContext _databaseContext;
        private readonly TipoClienteService _tipoClienteService;

        public ClienteService(
            DatabaseContext databaseContext,
            TipoClienteService tipoClienteService
            )
        { 
            _databaseContext = databaseContext;
            _tipoClienteService = tipoClienteService;
        }

        public ICollection<ClienteEntity> ObterTodos()
        {
            return _databaseContext.Clientes
                .Include(c => c.TipoCliente)
                .ToList();
        }

        public ClienteEntity ObterPorId(Guid id)
        {
            try
            {
                return _databaseContext.Clientes
                    .Include(c => c.TipoCliente)
                    .First(c => c.Id == id);

            }catch
            {
                throw new Exception("Cliente de ID #" + id + "não encontrado");
            }
        }
        public ClienteEntity Adicionar(IDadosBasicosClienteModel dadosBasicos)
        {
            var novoCliente = ValidarDadosBasicos(dadosBasicos);
            _databaseContext.Clientes.Add(novoCliente);
            _databaseContext.SaveChanges();

            return novoCliente;
        }
        
        public ClienteEntity Editar(
            Guid id,
            IDadosBasicosClienteModel dadosBasicos
            )
        {
            var clienteEntity = ObterPorId(id);
            clienteEntity = ValidarDadosBasicos(dadosBasicos, clienteEntity);
            _databaseContext.SaveChanges();

            return clienteEntity;
        }

        public ClienteEntity Remover(Guid id)
        {
            var clienteEntity = ObterPorId(id);
            _databaseContext.Clientes.Remove(clienteEntity);
            _databaseContext.SaveChanges();

            return clienteEntity;
        }

        private ClienteEntity ValidarDadosBasicos(
            IDadosBasicosClienteModel dadosBasicos,
            ClienteEntity entidadeExistente = null
            )
        {
            //Istanciar ou utilizar entidade previamente instanciada
            var entidade = entidadeExistente ?? new ClienteEntity();
            
            //Validar e Atribuir E-mail
            if (dadosBasicos.Email == null)
            {
                throw new Exception("Digite um e-mail válido");
            }

            entidade.Email = dadosBasicos.Email;
            
            //Validar Endereço
            if (dadosBasicos.Endereco == null)
            {
                throw new Exception("O endereço é obrigatório");
            }
            
            // Validar e Atribuir Tipo de Cliente
            if (dadosBasicos.TipoCliente == null)
            {
                throw new Exception("Escolha um tipo");
            }

            entidade.TipoCliente = _tipoClienteService.ObterPorId(Convert.ToInt32(dadosBasicos.TipoCliente));
            
            // Validar e Atribuir Observações
            if (dadosBasicos.Observacoes == null)
            {
                throw new Exception("Campo observações é obrigatório");
            }
            
            return entidade;
        }
        
        public interface IDadosBasicosClienteModel
        {
            public string Email { get; set; }
            public string Endereco { get; set; }
            public string TipoCliente { get; set; }
            public string Observacoes { get; set; }
        }
      
    }
    
}