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
    public class EditorMapping : BaseEntityMapping<Editor>
    {
        public override void Configure(EntityTypeBuilder<Editor> builder)
        {
            builder.HasData(new Editor() { ID = 1, FirstName = "Editor1", LastName = "Editor1", UserName = "editor1@tyf.com", Password = "123qwe.", CreatedBy = "System1", ModifiedBy = "System1", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });
            builder.HasData(new Editor() { ID = 2, FirstName = "Editor2", LastName = "Editor2", UserName = "editor2@tyf.com", Password = "123qwe.", CreatedBy = "System1", ModifiedBy = "System1", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });
            builder.HasData(new Editor() { ID = 3, FirstName = "Editor3", LastName = "Editor3", UserName = "editor3@tyf.com", Password = "123qwe.", CreatedBy = "System1", ModifiedBy = "System1", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });
            base.Configure(builder);
        }
    }
}
