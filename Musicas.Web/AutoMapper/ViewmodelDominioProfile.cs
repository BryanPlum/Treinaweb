using AutoMapper;
using Musicas.Dominio;
using Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musicas.Web.AutoMapper
{
    public class ViewModelDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
        }
    }
}