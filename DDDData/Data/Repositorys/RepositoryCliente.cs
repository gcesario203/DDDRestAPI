using DDDCore.Interfaces.Repositorys;
using DDDDomain.Entitys;

namespace DDDInfra.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext):base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
