using DDDCore.Interfaces.Repositorys;
using DDDCore.Interfaces.Services;
using DDDDomain.Entitys;

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
