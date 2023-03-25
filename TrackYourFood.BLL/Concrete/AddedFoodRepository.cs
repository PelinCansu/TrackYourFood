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
    public class AddedFoodRepository : IRepository<AddedFood>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(AddedFood item)
        {
            db.AddedFoods.Add(item);
            db.SaveChanges();
        }

        public List<AddedFood> GetByAll()
        {
            return db.AddedFoods.ToList();
        }

        public AddedFood GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(AddedFood item)
        {

            int _guncellenecekID = item.ID;
            db.Entry(db.AddedFoods.Find(_guncellenecekID)).CurrentValues.SetValues(item);

            db.SaveChanges();

        }

        public void Sil(AddedFood item)
        {

            db.Entry(db.AddedFoods.Find(item.ID)).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
