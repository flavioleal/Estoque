using Estoque.Business.Intefaces.Notificator;
using Estoque.Business.Interfaces.Repository;
using Estoque.Business.Interfaces.Service;
using Estoque.Business.Interfaces.UoW;
using Estoque.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IUnitOfWork _uow;
        private readonly IProdutoService _produtoService;

        public ProdutoService(INotificador notificador, IUnitOfWork uow, IProdutoService produtoService) : base(notificador)
        {
            _uow = uow;
            _produtoService = produtoService;
        }

        public Task Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
