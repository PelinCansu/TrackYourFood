using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Entites.Concrete;
using TrackYourFood.Mapping.Abstract;

namespace TrackYourFood.Mapping.Concrete
{
    public class MealMapping:BaseEntityMapping<Meal>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(m => m.MealType).HasMaxLength(20);

            builder.HasData(
                new Meal() { ID = 1, MealType = "Breakfast", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Meal() { ID = 2, MealType = "Lunch", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Meal() { ID = 3, MealType = "Dinner", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Meal() { ID = 4, MealType = "Snack", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });


            base.Configure(builder);
        }
    }
}
