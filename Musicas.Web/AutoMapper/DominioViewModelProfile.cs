using AutoMapper;
using Musicas.Dominio;
using Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicas.Web.AutoMapper
{
    public class DominioViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumIndexViewModel>()
            //CeateMap é um método que espera uma origem, e um destino para ser mapeado
            //O código abaixo personaliza a maneira como a propriedade NOME é exibida (da classe domínio para a view)
            .ForMember(p => p.Nome, opt =>
            {
                opt.MapFrom(src =>
                 string.Format("{0} ({1})", src.Nome, src.Ano.ToString())
                );
            });
            Mapper.CreateMap<Album, AlbumViewModel>();
        }
    }
}