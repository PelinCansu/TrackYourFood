using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TrackYourFood.BLL.Concrete;
using TrackYourFood.DAL;
using TrackYourFood.Entites.Concrete;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace TrackYourFood.UI
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Editor _gelenEditor;
        public Form11(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }

        TrackYourFoodContext db = new TrackYourFoodContext();
        FoodRepository foodRepository = new FoodRepository();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvEditor.DataSource = foodRepository.GetByAll();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
            cmbFoodID.Text = "Choose Item";
            cmbFoodID.Items.AddRange(db.Foods.ToArray());

            cmbCatId.Text = "Choose Item";
            cmbCatId.Items.AddRange(db.Categories.ToArray());

            cmbMealId.Text = "Choose Item";
            cmbMealId.Items.AddRange(db.Meals.ToArray());

            cmbUnitId.Text = "Choose Item";
            cmbUnitId.Items.AddRange(db.Units.ToArray());
         
        }
        //SqlConnection sqlConnection = new SqlConnection(@"Server=.;Database=TrackYourFoodDB;uid=sa;pwd=123; TrustServerCertificate=True");
        //SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGSF2JRK;Initial Catalog= TrackYourFoodDB; Integrated Security=True; TrustServerCertificate=True");

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbFood.ImageLocation = openFileDialog1.FileName;
            txtPicture.Text = openFileDialog1.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Food _eklenecekYemek = new Food()
            {
                FoodName = txtFoodName.Text,
                ProteinValue = Math.Round(Convert.ToDouble(txtProteinValue.Text),2),
                CarboValue = Math.Round(Convert.ToDouble(txtCarboValue.Text),2),
                FatValue = Math.Round(Convert.ToDouble(txtFatValue.Text),2),
                Kcal = Math.Round(Convert.ToDouble(txtKcalValue.Text),2),
                CreatedBy = _gelenEditor.UserName,
                ModifiedBy = _gelenEditor.UserName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Picture=txtPicture.Text
            };

            Meal seciliMeal = (Meal)cmbMealId.SelectedItem;
            _eklenecekYemek.MealID = seciliMeal.ID; 
            Unit seciliUnit = (Unit)cmbUnitId.SelectedItem;
            _eklenecekYemek.UnitID = seciliUnit.ID;
            Category seciliCategory = (Category)cmbCatId.SelectedItem;
            _eklenecekYemek.CategoryID = seciliCategory.ID;
         

            foodRepository.Ekle(_eklenecekYemek);
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("insert into dbo.Foods (FoodName, ProteinValue, FatValue, CarboValue, Kcal, CategoryID, UnitID, Picture, MealID, CreatedDate, ModifiedDate, CreatedBy, ModifiedBy) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13)", baglanti);

            //komut.Parameters.AddWithValue("@p1", txtFoodName.Text);
            //komut.Parameters.AddWithValue("@p2",Convert.ToDouble(txtProteinValue.Text));
            //komut.Parameters.AddWithValue("@p3",Convert.ToDouble (txtFatValue.Text));
            //komut.Parameters.AddWithValue("@p4", Convert.ToDouble( txtCarboValue.Text));
            //komut.Parameters.AddWithValue("@p5",Convert.ToDouble( txtKcalValue.Text));

            //Food _food = new Food();

            //Category secili = (Category)cmbCatId.SelectedItem;
            //_food.CategoryID = secili.ID;
        
           // komut.Parameters.AddWithValue("@p6", 1);


           // komut.Parameters.AddWithValue("@p7", 1);

           // komut.Parameters.AddWithValue("@p8", txtPicture.Text);


           ////Meal seciliMeal = (Meal)cmbMealId.SelectedItem;

           // komut.Parameters.AddWithValue("@p9", 1);
           // komut.Parameters.AddWithValue("@p10", DateTime.Now);
           // komut.Parameters.AddWithValue("@p11", DateTime.Now);
           // komut.Parameters.AddWithValue("@p12", _gelenEditor.UserName);
           // komut.Parameters.AddWithValue("@p13", "EmreGurcan");

           // komut.ExecuteNonQuery();
           // baglanti.Close();
           // MessageBox.Show("Food is added.");

           dgvEditor.DataSource = foodRepository.GetByAll();


            cmbFoodID.Items.Clear();
            cmbFoodID.Text = "Choose Item";
            cmbFoodID.Items.AddRange(db.Foods.ToArray());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int _seciliID = Convert.ToInt32(dgvEditor.SelectedRows[0].Cells[0].Value);
            foodRepository.Sil(db.Foods.Find(_seciliID));
            //foreach (DataGridViewRow drow in dgvCategory.SelectedRows)  //Seçili Satırları Silme
            //{
            //}
            dgvEditor.DataSource = foodRepository.GetByAll();

            cmbFoodID.Items.Clear();
            cmbFoodID.Text = "Choose Item";
            cmbFoodID.Items.AddRange(db.Foods.ToArray());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //int _seciliFoodID = Convert.ToInt32(dgvEditor.SelectedRows[0].Cells[0].Value);

            Food _seciliFood = (Food)cmbFoodID.SelectedItem;
            int ID = _seciliFood.ID;

            Food _guncellenecek = db.Foods.Find(ID);

            _guncellenecek.FoodName = txtFoodName.Text;
            _guncellenecek.ProteinValue = Math.Round(Convert.ToDouble(txtProteinValue.Text), 2);
            _guncellenecek.CarboValue = Math.Round(Convert.ToDouble(txtCarboValue.Text),2);
            _guncellenecek.FatValue = Math.Round(Convert.ToDouble(txtFatValue.Text),2);
            _guncellenecek.Kcal = Math.Round(Convert.ToDouble(txtKcalValue.Text),2);
            _guncellenecek.CreatedBy = _gelenEditor.UserName;
            _guncellenecek.ModifiedBy = _gelenEditor.UserName;
            _guncellenecek.CreatedDate = DateTime.Now;
            _guncellenecek.ModifiedDate = DateTime.Now;
            _guncellenecek.Picture = txtPicture.Text;

            Meal seciliMeal = (Meal)cmbMealId.SelectedItem;
            _guncellenecek.MealID = seciliMeal.ID;
            Unit seciliUnit = (Unit)cmbUnitId.SelectedItem;
            _guncellenecek.UnitID = seciliUnit.ID;
            Category seciliCategory = (Category)cmbCatId.SelectedItem;
            _guncellenecek.CategoryID = seciliCategory.ID;

            foodRepository.Guncelle(_guncellenecek);

            dgvEditor.DataSource = foodRepository.GetByAll();
        }

        private void cmbFoodID_SelectedIndexChanged(object sender, EventArgs e)
        {

            Food _seciliFood = (Food)cmbFoodID.SelectedItem;
            int ID = _seciliFood.ID;

            txtFoodName.Text = _seciliFood.FoodName;
            txtCarboValue.Text = _seciliFood.CarboValue.ToString() ;
            txtFatValue.Text = _seciliFood.FatValue.ToString() ;
            txtProteinValue.Text = _seciliFood.ProteinValue.ToString() ;
            txtKcalValue.Text = _seciliFood.Kcal.ToString() ;
            txtPicture.Text = _seciliFood.Picture;



            //cmbCatId.SelectedItem = db.Foods.Where(x => x.CategoryID == _seciliFood.CategoryID).Select(x => x.CategoryID).ToList(); ;






        }
    }
}
