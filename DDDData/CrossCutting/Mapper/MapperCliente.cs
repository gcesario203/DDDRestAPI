using DDDApplication.Dtos;
using DDDDomain.Entitys;
using DDDInfra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDInfra.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(cliente => new ClienteDto
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Sobrenome = cliente.Sobrenome,
                    Email = cliente.Email
                }
            );

            return dto;
        }
    }
}
