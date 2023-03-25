using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Entites.Concrete
{
    public class Meal : BaseEntity, IBaseEntityID
    {
        public Meal()
        {
            Foods = new HashSet<Food>();
        }
        public int ID { get; set; }

        public string MealType { get; set; }

        public ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {MealType}";

        }
    }
}
