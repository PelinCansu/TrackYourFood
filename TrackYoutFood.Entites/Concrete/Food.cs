using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Core.Interfaces;
using TrackYourFood.Entites.Abstract;
using System.Drawing;
using System.IO;
using System.Data;
using System.ComponentModel.Design;


namespace TrackYourFood.Entites.Concrete
{
    public class Food:BaseEntity,IBaseEntityID
    {
        public Food()
        {
            AddedFoods = new HashSet<AddedFood>();
       
            
        }
        public int ID { get; set; }
        public string FoodName { get; set; }
        public double ProteinValue { get; set; }
        public double FatValue { get; set; }
        public double CarboValue { get; set; }
        public double Kcal { get; set; }
        public int CategoryID { get; set; }
        public int UnitID { get; set; }
        public string? Picture { get; set; }
        public int MealID { get; set; }


        public override string ToString()
        {
            return $"Food ID: {ID}, Food Name: {FoodName}, Kcal: {Kcal}";
        }

        //NP
        public Category Category { get; set; }
        public Unit Unit { get; set; }
        public Meal Meal { get; set; }

        public ICollection<AddedFood> AddedFoods { get; set; }
        
    }
}
