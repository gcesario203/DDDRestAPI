using DDDCore.Interfaces.Repositorys;
using DDDCore.Interfaces.Services;
using DDDDomain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDServices
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repository;

        public ServiceProduto(IRepositoryProduto repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
