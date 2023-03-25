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
    public class UnitMapping:BaseEntityMapping<Unit>
    {
        public override void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.Property(u => u.NameOfUnit).HasMaxLength(10);

            builder.HasData(
                new Unit() { ID = 1, NameOfUnit = "gr", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Unit() { ID = 2, NameOfUnit = "quantity", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Unit() { ID = 3, NameOfUnit = "portion", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Unit() { ID = 4, NameOfUnit = "litre", CreatedBy = "Emre Gurcan", ModifiedBy = "Emre Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });

            base.Configure(builder);
        }
    }
}
