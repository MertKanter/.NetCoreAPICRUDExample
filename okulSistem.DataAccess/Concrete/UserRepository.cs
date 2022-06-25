using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.DataAccess.Abstract;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                return okulSistemDbContext.Users.ToList();
            }
        }

        public User GetByUserId(int id)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                return okulSistemDbContext.Users.Find(id);
            }
        }

        public User CreateUser(User user)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                okulSistemDbContext.Users.Add(user);
                okulSistemDbContext.SaveChanges();
                return user;
            }
        }

        public User UpdateUser(User user)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                okulSistemDbContext.Users.Update(user);
                okulSistemDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                var deleteUser = GetByUserId(id);
                okulSistemDbContext.Users.Remove(deleteUser);
                okulSistemDbContext.SaveChanges();

            }
        }
    }
}
