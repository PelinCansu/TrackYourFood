using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Entites.Concrete
{
    public class Category:BaseEntity,IBaseEntityID
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {CategoryName}";
        }

    }
}
