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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        Editor _gelenEditor;
        public Form12(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void Form12_Load(object sender, EventArgs e)
        {
            txtTotalActiveUser.Text = db.Users.Count().ToString();
            txtTotalUser.Text = db.Users.Count().ToString();
            dgvUserOrdering.DataSource = db.AddedFoods.GroupBy(a => a.UserID).Select(group => new
            {
                User_ID = group.Key,
                Food_Count = group.Count()
                
            }).OrderByDescending(x=>x.Food_Count).ToList();


            dgvMostAddedFoodOrder.DataSource = db.AddedFoods.GroupBy(a => a.Food.FoodName).Select(group => new
            {
                Food_Name = group.Key,
                Food_Count = group.Count()

            }).OrderByDescending(x => x.Food_Count).ToList();



            dgvMealBasedOrder.DataSource = db.AddedFoods.GroupBy(a => a.Food.Meal.MealType).Select(group => new
            {
                Meal_Type = group.Key,
                AddedFood_Count = group.Count()

            }).OrderByDescending(x => x.AddedFood_Count).ToList();



            dgvCategoryBasedOrder.DataSource = db.AddedFoods.GroupBy(a => a.Food.Category.CategoryName).Select(group => new
            {
                Category = group.Key,
                AddedFood_Count = group.Count()

            }).OrderByDescending(x => x.AddedFood_Count).ToList();
        }
    }
}
