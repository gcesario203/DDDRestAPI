using DDDCore.Interfaces.Repositorys;
using DDDDomain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDInfra.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
