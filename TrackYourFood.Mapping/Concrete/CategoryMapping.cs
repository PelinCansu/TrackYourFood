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
    public class CategoryMapping:BaseEntityMapping<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.CategoryName).HasMaxLength(40);
            base.Configure(builder);

            builder.HasData(
                new Category() { ID = 1, CategoryName = "Vegetables", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Category() { ID = 2, CategoryName = "Fruits", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Category() { ID = 3, CategoryName = "Dairy", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Category() { ID = 4, CategoryName = "Grains", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Category() { ID = 5, CategoryName = "Protein", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });
        }
    }
}
