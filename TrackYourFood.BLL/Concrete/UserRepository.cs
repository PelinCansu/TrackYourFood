using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.DAL;
using TrackYourFood.Entites.Concrete;

namespace TrackYourFood.BLL.Concrete
{
    public class UserRepository : IRepository<User>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public List<User> GetByAll()
        {
            return db.Users.ToList();
        }

        public User GetByID(int id)
        {
            if (db.Users.Find(id) is null)
            {
                throw new NullReferenceException("Aranan değer bulunamadı.");
            }
            return db.Users.Find(id);
        }

        public void Guncelle(User item)
        {
            db.Users.Update(item);
            db.SaveChanges();
        }

        public void Sil(User item)
        {
            db.Users.Remove(item);
            db.SaveChanges();
        }
    }
}
