using DDDApplication.Dtos;
using DDDDomain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDApplication.Interface.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
