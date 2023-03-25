using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackYourFood.BLL.Concrete;
using TrackYourFood.DAL;
using TrackYourFood.Entites.Concrete;

namespace TrackYourFood.UI
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        Editor _gelenEditor;
        public Form9(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }
        MealRepository mealRepository = new MealRepository();
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Meal _eklenecek = new Meal()
            {
                MealType = txtMealType.Text,
                CreatedBy = _gelenEditor.UserName,
                ModifiedBy = _gelenEditor.UserName,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now

            };
            mealRepository.Ekle(_eklenecek);

            dgvEditorMeal.DataSource = mealRepository.GetByAll();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int _seciliID = Convert.ToInt32(dgvEditorMeal.SelectedRows[0].Cells[0].Value);
            mealRepository.Sil(db.Meals.Find(_seciliID));
            //foreach (DataGridViewRow drow in dgvCategory.SelectedRows)  //Seçili Satırları Silme
            //{
            //}
            dgvEditorMeal.DataSource = mealRepository.GetByAll();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvEditorMeal.DataSource = mealRepository.GetByAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int _seciliKategoriId = Convert.ToInt32(dgvEditorMeal.SelectedRows[0].Cells[0].Value);

            Meal _guncellenecek = db.Meals.Find(_seciliKategoriId);
            _guncellenecek.MealType = txtMealType.Text;

            mealRepository.Guncelle(_guncellenecek);

            dgvEditorMeal.DataSource = mealRepository.GetByAll();


        }
    }
}
