using AutoMapper;
using EasyModular.AutoMapper;
using EasyModular.Admin.Domain.Organization;
using System;
using System.Collections.Generic;
using System.Text;
using EasyModular.Admin.Domain.Organization.Models;

namespace EasyModular.Admin.Application.Organization.Models
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<OrganizationAddModel, OrganizationEntity>();
            cfg.CreateMap<OrganizationEntity, OrganizationUpdateModel>();
        }
    }
}
