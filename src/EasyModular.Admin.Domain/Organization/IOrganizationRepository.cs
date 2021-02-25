using EasyModular.SqlSugar;
using EasyModular.Admin.Domain.Organization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EasyModular.Admin.Domain.Organization.Models;

namespace EasyModular.Admin.Domain.Organization
{
    public interface IOrganizationRepository : IRepository<OrganizationEntity>
    {
        Task<IList<OrganizationEntity>> Query(OrganizationQueryModel model);
    }
}
