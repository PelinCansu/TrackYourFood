using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Entites.Concrete
{
    public class AddedFood:BaseEntity, IBaseEntityID
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public double Quantity { get; set; }
        public double CalculatedProtein { get; set; }
        public double CalculatedFat { get; set; }
        public double CalculatedCarbo { get; set; }
        public double CalculatedKcal { get; set; }

        //NP
        public User User { get; set; }
        public Food Food { get; set; }


    }
}
