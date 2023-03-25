using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Entites.Concrete;
using TrackYourFood.Mapping.Abstract;

namespace TrackYourFood.Mapping.Concrete
{
    public class AddedFoodMapping:BaseEntityMapping<AddedFood>
    {
        public override void Configure(EntityTypeBuilder<AddedFood> builder)
        {
            //builder.HasKey(k => new);



            base.Configure(builder);
        }
    }
}
