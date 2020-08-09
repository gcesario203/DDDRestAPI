using DDDApplication.Dtos;
using DDDApplication.Interface;
using DDDApplication.Interface.Mappers;
using DDDCore.Interfaces.Services;
using System.Collections.Generic;

namespace DDDApplication
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente); 
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClienteDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
