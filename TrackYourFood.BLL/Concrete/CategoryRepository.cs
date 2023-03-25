using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
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
    public class CategoryRepository : IRepository<Category>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public List<Category> GetByAll()
        {
            return db.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return db.Categories.Find(id);
        }

        public void Guncelle(Category item)
        {
            //db.Categories.Entry(item).State = EntityState.Modified;
            int _guncellenecekID = item.ID;
            db.Entry(db.Categories.Find(_guncellenecekID)).CurrentValues.SetValues(item);
            
            db.SaveChanges();
        }

        public void Sil(Category item)
        {
            //db.Categories.Entry(item).State = EntityState.Deleted;
            //db.SaveChanges();


            db.Entry(db.Categories.Find(item.ID)).State = EntityState.Deleted;
            //db.Categories.Remove(item);
            db.SaveChanges();

        }
    }
}
