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
    public class EditorRepository : IRepository<Editor>
    {
        TrackYourFoodContext db = new TrackYourFoodContext();
        public void Ekle(Editor item)
        {
            db.Editors.Add(item);
            db.SaveChanges();
        }

        public List<Editor> GetByAll()
        {
            return db.Editors.ToList();
        }

        public Editor GetByID(int id)
        {
            return db.Editors.Find(id);
        }

        public void Guncelle(Editor item)
        {
            db.Editors.Update(item);
            db.SaveChanges();
        }

        public void Sil(Editor item)
        {
            db.Editors.Remove(item);
            db.SaveChanges();

        }
    }
}
