using AutoMapper;
using EasyModular.AutoMapper;
using EasyModular.Admin.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyModular.Admin.Application.User.Models
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<UserAddModel, UserEntity>();
            cfg.CreateMap<UserEntity, UserUpdateModel>();
        }
    }
}
