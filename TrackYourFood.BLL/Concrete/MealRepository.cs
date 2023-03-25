using Microsoft.EntityFrameworkCore;
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
    public class MealRepository : IRepository<Meal>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(Meal item)
        {
            db.Meals.Add(item);
            db.SaveChanges();
        }

        public List<Meal> GetByAll()
        {
            return db.Meals.ToList();
        }

        public Meal GetByID(int id)
        {
            return db.Meals.Find(id);
        }

        public void Guncelle(Meal item)
        {
            int _guncellenecekID = item.ID;
            db.Entry(db.Meals.Find(_guncellenecekID)).CurrentValues.SetValues(item);

            db.SaveChanges();
        }

        public void Sil(Meal item)
        {
            db.Entry(db.Meals.Find(item.ID)).State = EntityState.Deleted;
            //db.Categories.Remove(item);
            db.SaveChanges();

        }
    }
}
