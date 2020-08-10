using DDDCore.Interfaces.Repositorys;
using DDDCore.Interfaces.Services;
using DDDDomain.Entitys;

namespace DDDServices
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repository;

        public ServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
