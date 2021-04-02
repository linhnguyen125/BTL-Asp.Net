using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.DAO
{
    public class UserDAO
    {
        TGDDDbContext db = null;

        public UserDAO()
        {
            db = new TGDDDbContext();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public int Login(string username, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if(result.Status == false)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        public User GetById(string username)
        {
            return db.Users.SingleOrDefault(x => x.Username == username);
        }
    }
}
