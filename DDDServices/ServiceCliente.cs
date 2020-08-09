using DDDCore.Interfaces.Repositorys;
using DDDCore.Interfaces.Services;
using DDDDomain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDServices
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceBase<Cliente>
    {
        private readonly IRepositoryCliente repository;

        public ServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
