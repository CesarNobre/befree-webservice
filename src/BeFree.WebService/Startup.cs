using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using AutoMapper;
using BeFree.WebService.Request;
using BeFree.WebService.Domain;
using BeFree.WebService.Response;

[assembly: OwinStartup(typeof(BeFree.WebService.Startup))]

namespace BeFree.WebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			Mapper.Initialize(cfg => cfg.CreateMap<UserRequest, User>());
			Mapper.Initialize(cfg => cfg.CreateMap<User, UserResponse>());
			Mapper.Initialize(cfg => cfg.CreateMap<Cadeira, CadeiraResponse>());
			Mapper.Initialize(cfg => cfg.CreateMap<Mesa, MesaResponse>());
			Mapper.Initialize(cfg => cfg.CreateMap<MesaResponse, Mesa>());
			Mapper.Initialize(cfg => cfg.CreateMap<Shopping, ShoppingRequest > ()
			.ForMember(dest => dest.Mesas, opt => opt.MapFrom(src => src.Mesas)));

			Mapper.Initialize(cfg => cfg.CreateMap<Shopping, ShoppingResponse>());

			ConfigureAuth(app);
        }
    }
}
