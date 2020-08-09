using DDDApplication.Dtos;
using System.Collections.Generic;


namespace DDDApplication.Interface
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);
        void Update(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}
