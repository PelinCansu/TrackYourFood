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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        User _gelenUser;
        public Form5(User gelenUser)
        {
            _gelenUser = gelenUser;
            InitializeComponent();

        }
       

        TrackYourFoodContext db = new TrackYourFoodContext();
        private void Form5_Load(object sender, EventArgs e)
        {
            dgvMonthlyReport.DataSource = db.AddedFoods.Where(x => x.UserID == _gelenUser.ID && (x.CreatedDate >= DateTime.Today.AddDays(-31) & x.CreatedDate <= DateTime.Now)).Select(x=> new
            {
                x.Food.FoodName,
                x.CalculatedFat,
                x.CalculatedCarbo,
                x.CalculatedProtein,
                x.CalculatedKcal,
                x.CreatedDate


            }).ToList();


            txtMonthlyKcalTotal.Text = ToplamKaloriHesapla().ToString();
            txtMonthlyTotalCarbo.Text = ToplamCarboHesapla().ToString();
            txtMonthlyTotalFat.Text = ToplamFatHesapla().ToString();
            txtMonthlyTotalPro.Text = ToplamProHesapla().ToString();
        }

        public double ToplamKaloriHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-31) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);

        }
        public double ToplamProHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-31) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-31) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && (u.CreatedDate >= DateTime.Today.AddDays(-31) & u.CreatedDate <= DateTime.Now)).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
