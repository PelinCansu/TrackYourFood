using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrackYourFood.Entites.Concrete;
using TrackYourFood.Mapping.Abstract;
using System.IO;

namespace TrackYourFood.Mapping.Concrete
{
    public class FoodMapping:BaseEntityMapping<Food>
    {
        public override void Configure(EntityTypeBuilder<Food> builder)
        {

            builder.HasData(
                new Food() { ID = 1, FoodName = "Green Peas", CategoryID = 1, UnitID = 1, ProteinValue = 3.48, FatValue = 10.38, CarboValue = 11.07, Kcal = 147, MealID = 2 , Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\bezelye.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 2, FoodName = "Artichokes in oil", CategoryID = 1, UnitID = 1, ProteinValue = 1.8, FatValue = 5, CarboValue = 4.7, Kcal = 79, MealID=2 , Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\zeytinyagli-enginar-500x500.jpeg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 3, FoodName = "Apple", MealID=4, CategoryID = 2, UnitID = 2, ProteinValue = 0.36, FatValue = 0.24, CarboValue = 19.3, Kcal = 73,  Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\star-elma-p-2246.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 4, FoodName = "Banana", CategoryID = 2, UnitID = 2, ProteinValue = 1.29, FatValue = 0.39, CarboValue = 26.95, Kcal = 105,MealID=4, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\benekli-muz.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 5, FoodName = "Milk", CategoryID = 3, UnitID = 4, ProteinValue = 3.32, FatValue = 3.35, CarboValue = 4.66, Kcal = 62, MealID=1, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\sut.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 6, FoodName = "White cheese", CategoryID = 3, UnitID = 1, ProteinValue = 14.21, FatValue = 21.28, CarboValue = 4.09, Kcal = 264, MealID=1, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\beyazPeynir.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 7, FoodName = "Dried beans", CategoryID = 4, UnitID = 1, ProteinValue = 22.00, FatValue = 1.40, CarboValue = 29.40, Kcal = 282, MealID=2, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\kurufasulye.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 8, FoodName = "Pea meal", CategoryID = 4, UnitID = 1, ProteinValue = 8.30, FatValue = 0.83, CarboValue = 17.2, Kcal = 110, MealID=2, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\nohut.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 9, FoodName = "Beef steak", CategoryID = 5, UnitID = 1, ProteinValue = 29.81, FatValue = 6.63, CarboValue = 0, Kcal = 187,MealID=3, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\biftek.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                 new Food() { ID = 12, FoodName = "Chicken breast", CategoryID = 5, UnitID = 1, ProteinValue = 23.10, FatValue = 1.24, CarboValue = 0, Kcal = 110, MealID = 3, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\izgara-tavuk-gogsu.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today },
                new Food() { ID = 11, FoodName = "Boiled Egg", CategoryID = 5, UnitID = 1, ProteinValue = 6.29, FatValue = 5.3, CarboValue = 0, Kcal = 78, MealID=1, Picture = @"C:\Users\emreg\OneDrive\Masaüstü\TrackYourFood\FoodPicture\yumurta.jpg", CreatedBy = "Pelin Gurcan", ModifiedBy = "Pelin Gurcan", CreatedDate = DateTime.Today, ModifiedDate = DateTime.Today });



            base.Configure(builder);
        }

        #region Resim ekleme metodu
        //public static byte[] ReadFile(string sPath)
        //{
        //    //Initialize byte array with a null value initially.
        //    byte[] data = null;

        //    //Use FileInfo object to get file size.
        //    FileInfo fInfo = new FileInfo(sPath);
        //    long numBytes = fInfo.Length;

        //    //Open FileStream to read file
        //    FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

        //    //Use BinaryReader to read file stream into byte array.
        //    BinaryReader br = new BinaryReader(fStream);

        //    //When you use BinaryReader, you need to supply number of bytes 
        //    //to read from file.
        //    //In this case we want to read entire file. 
        //    //So supplying total number of bytes.
        //    data = br.ReadBytes((int)numBytes);

        //    return data;
        //} 
        #endregion
    }
}
