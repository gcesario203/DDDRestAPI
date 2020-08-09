using DDDApplication.Dtos;
using DDDApplication.Interface;
using DDDApplication.Interface.Mappers;
using DDDCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDApplication
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public void Add(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}
