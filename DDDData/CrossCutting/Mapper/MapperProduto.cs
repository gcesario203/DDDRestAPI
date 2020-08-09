using DDDApplication.Dtos;
using DDDDomain.Entitys;
using DDDInfra.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDInfra.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(produto => new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            });

            return dto;
        }
    }
}
