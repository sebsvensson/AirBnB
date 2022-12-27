using DataLayer.Repositories.Interface;
using Model;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AirBnbContext dbContext)
            : base(dbContext)
        {

        }

        public override void Remove(User entity)
        {
            Context.Users.Where(x => x.Username == entity.Username).FirstOrDefault();
            base.Remove(entity);    
        }

        public User? GetLoginUser(string username, string password)
        {
            return Context.Set<User>()
                .Where(user => user.Username == username && user.Password == password)
                .FirstOrDefault();
        }

        public User? GetByUserId(string username)
        {
            return Context.Set<User>()
                .Where(x => x.Username == username)
                .FirstOrDefault();
        }

        //public User? GetByPassword(string password)
        //{
        //    return Context.Set<User>()
        //        .Where(x => x.Password == password)
        //        .FirstOrDefault();
        //}


    }
}