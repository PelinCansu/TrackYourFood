using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackYourFood.DAL;
using TrackYourFood.Entites.Concrete;

namespace TrackYourFood.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        User _gelenUser;
        public Form4(User gelenUser)
        {
            _gelenUser = gelenUser;
            InitializeComponent();

        }
        private void btnAylikRapor2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_gelenUser);
            form5.Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void Form4_Load(object sender, EventArgs e)
        {

            dgvWeeklyReport.DataSource = db.AddedFoods.Where(x => x.UserID == _gelenUser.ID && (x.CreatedDate >= DateTime.Today.AddDays(-7) & x.CreatedDate <= DateTime.Now)).Select(x => new
            {
                x.Food.FoodName,
                x.CalculatedFat,
                x.CalculatedCarbo,
                x.CalculatedProtein,
                x.CalculatedKcal,
                x.CreatedDate


            }).ToList();

            txtWeeklyKcalTotal.Text = ToplamKaloriHesapla().ToString();
            txtWeeklyTotalCarbo.Text = ToplamCarboHesapla().ToString();
            txtWeeklyTotalFat.Text = ToplamFatHesapla().ToString();
            txtWeeklyTotalPro.Text = ToplamProHesapla().ToString();

            #region MukemmelGroupBy
            //dgvAverage.DataSource = db.AddedFoods.Where(u => u.CreatedDate >= DateTime.Today.AddDays(-7) && u.CreatedDate <= DateTime.Now).GroupBy(a => new { ID = a.UserID }).Select(x => new
            //{
            //    UserID = x.Key,
            //    Sum = x.Sum(x => x.CalculatedKcal),

            //}).ToList();




            #endregion





            //dgvWeeklyReport.DataSource = db.AddedFoods.Where(x => x.UserID == _gelenUser.ID && (x.CreatedDate >= DateTime.Today.AddDays(-7) & x.CreatedDate <= DateTime.Now)).GroupBy(y => y.CreatedDate.Date).Select(group => new
            //{
            //    TotalKcal = group.Count(),
            //    Date = group.Key

            //}).ToList();
        }


        //public double OrtalamaHesaplama()
        //{
        //    var toplam = db.AddedFoods.Where(u => u.CreatedDate >= DateTime.Today.AddDays(-7) & u.CreatedDate <= DateTime.Now).Sum(x => x.CalculatedKcal);

        //    var ortalama 

        //    return Math.Round(toplam, 2);
        //}

        public double ToplamKaloriHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-7) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);

        }
        public double ToplamProHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-7) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-7) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-7) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        }

      
    }
}
