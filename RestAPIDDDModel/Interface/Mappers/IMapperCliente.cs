using DDDApplication.Dtos;
using DDDDomain.Entitys;
using System.Collections.Generic;

namespace DDDApplication.Interface.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
