﻿using EasyModular.SqlSugar;
using EasyModular.Admin.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EasyModular.Admin.Domain.Organization.Models;
using System.Linq;
using SqlSugar;
using System.Linq.Expressions;
using EasyModular.Admin.Domain.Organization;

namespace EasyModular.Admin.Infrastructure.Repositories.Organization
{
    public class OrganizationrRepository : RepositoryBase<OrganizationEntity>, IOrganizationRepository
    {
        public OrganizationrRepository(IDbContext context) : base(context)
        {

        }

        public async Task<IList<OrganizationEntity>> Query(OrganizationQueryModel model)
        {
            var query = DbContext.Db.Queryable<OrganizationEntity>().Where(m=>m.IsDel==false);

            query.WhereIF(!SqlFunc.IsNullOrEmpty(model.OrganizeCode), m => m.OrganizeCode.Contains(model.OrganizeCode));
            query.WhereIF(!SqlFunc.IsNullOrEmpty(model.OrganizeName), m => m.OrganizeName.Contains(model.OrganizeName));

            if (!string.IsNullOrEmpty(model.OrderFileds))
                query.OrderBy(model.OrderFileds);

            RefAsync<int> totalCount = 0;
            var data= await query.ToPageListAsync(model.PageIndex, model.PageSize, totalCount);
            model.TotalCount = totalCount;

            return data;
        }
    }
}
