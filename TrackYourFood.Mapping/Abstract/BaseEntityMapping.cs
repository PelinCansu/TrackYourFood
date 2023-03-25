using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Entites.Abstract;

namespace TrackYourFood.Mapping.Abstract
{
    public abstract class BaseEntityMapping<T> : IEntityTypeConfiguration<T> where T:BaseEntity
    {
       
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
