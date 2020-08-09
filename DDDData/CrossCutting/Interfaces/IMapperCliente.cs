using DDDApplication.Dtos;
using DDDDomain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDInfra.CrossCutting.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
