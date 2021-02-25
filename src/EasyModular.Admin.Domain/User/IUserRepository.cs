using EasyModular.SqlSugar;
using EasyModular.Admin.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EasyModular.Admin.Domain.User.Models;

namespace EasyModular.Admin.Domain.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<IList<UserEntity>> Query(UserQueryModel model);
    }
}
