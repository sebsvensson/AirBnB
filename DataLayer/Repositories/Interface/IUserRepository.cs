using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetLoginUser(string username, string password);
        User? GetByUserId(string username);
    }
}
