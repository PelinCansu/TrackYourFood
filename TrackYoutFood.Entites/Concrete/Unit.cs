using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Entites.Concrete
{
    public class Unit : BaseEntity, IBaseEntityID
    {
        public Unit()
        {
            Foods = new HashSet<Food>();
        }
        public int ID { get; set; }

        public string NameOfUnit { get; set; }

        //NP
        public ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {NameOfUnit}";

        }
    }
}
