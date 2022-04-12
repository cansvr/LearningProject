using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class UserRepository : IUserDal
    {
        Context c = new Context();
        DbSet<User> _object;

        public List<User> List()
        {
            return _object.ToList();
        }

        public void Insert(User p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Update(User p)
        {
            c.SaveChanges();
        }

        public void Delete(User p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public List<User> List(Expression<Func<User, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }
    }
}
