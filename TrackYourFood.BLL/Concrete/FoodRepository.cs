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
    public class FoodRepository : IRepository<Food>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(Food item)
        {
            db.Foods.Add(item);
            db.SaveChanges();
        }

        public List<Food> GetByAll()
        {
            return db.Foods.ToList();
        }

        public Food GetByID(int id)
        {
            return db.Foods.Find(id);
        }

        public void Guncelle(Food item)
        {
            int _guncellenecekID = item.ID;
            db.Entry(db.Foods.Find(_guncellenecekID)).CurrentValues.SetValues(item);

            db.SaveChanges();
        }

        public void Sil(Food item)
        {

            db.Entry(db.Foods.Find(item.ID)).State = EntityState.Deleted;
            //db.Categories.Remove(item);
            db.SaveChanges();

        }
    }
}
