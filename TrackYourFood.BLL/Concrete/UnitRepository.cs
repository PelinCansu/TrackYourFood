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
    public class UnitRepository : IRepository<Unit>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(Unit item)
        {
            db.Units.Add(item);
            db.SaveChanges();
        }

        public List<Unit> GetByAll()
        {
            return db.Units.ToList();
        }

        public Unit GetByID(int id)
        {
            return db.Units.Find(id);
        }

        public void Guncelle(Unit item)
        {
            int _guncellenecekID = item.ID;
            db.Entry(db.Units.Find(_guncellenecekID)).CurrentValues.SetValues(item);

            db.SaveChanges();
        }

        public void Sil(Unit item)
        {
            db.Entry(db.Units.Find(item.ID)).State = EntityState.Deleted;
            //db.Categories.Remove(item);
            db.SaveChanges();

        }
    }
}
