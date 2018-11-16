using System;
using AutoMapper;
using IO.Domain;

namespace IO.Web.Services.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //CreateMap<EventoViewModel, RegistrarEventoCommand>()
            //    .ConstructUsing(c => new RegistrarEventoCommand(c.Nome, c.DescricaoCurta, c.DescricaoLonga, c.DataInicio, c.DataFim, c.Gratuito, c.Valor, c.Online, c.NomeEmpresa, c.OrganizadorId, c.CategoriaId,
            //        new IncluirEnderecoEventoCommand(c.Endereco.Id, c.Endereco.Logradouro, c.Endereco.Numero, c.Endereco.Complemento, c.Endereco.Bairro, c.Endereco.CEP, c.Endereco.Cidade, c.Endereco.Estado, c.Id)));
        }
    }
}
