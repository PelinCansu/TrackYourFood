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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        User _gelenUser;
        public Form3(User gelenUser)
        {
            _gelenUser = gelenUser;
            InitializeComponent();

        }
        TrackYourFoodContext db = new TrackYourFoodContext();
        AddedFoodRepository addedFoodRepository = new AddedFoodRepository();
        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Listele();


            cmbBreakfast.Text = "Choose Item";
            cmbBreakfast.Items.AddRange(db.Foods.Where(f => f.MealID == 1).ToArray());

            cmbUnit.DataSource = db.Units.Select(u => u.NameOfUnit).ToList();

            cmbDinner.Text = "Choose Item";
            cmbDinner.Items.AddRange(db.Foods.Where(f => f.MealID == 3).ToArray());

            cmbLunch.Text = "Choose Item";
            cmbLunch.Items.AddRange(db.Foods.Where(f => f.MealID == 2).ToArray());


            cmbSnack.Text = "Choose Item";
            cmbSnack.Items.AddRange(db.Foods.Where(f => f.MealID == 4 ).ToArray());

            pBoxFood.Image = Properties.Resources.tyf_logo;
            pBoxFood.BackgroundImageLayout = ImageLayout.Stretch;

            TextBoxDoldur();

        }

        private void rbBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            RbAktifPasifYap(rbBreakfast, cmbBreakfast);

        }

        private void rbLunch_CheckedChanged(object sender, EventArgs e)
        {

            RbAktifPasifYap(rbLunch, cmbLunch);

        }

        private void rbDinner_CheckedChanged(object sender, EventArgs e)
        {

            RbAktifPasifYap(rbDinner, cmbDinner);

        }

        private void rbSnack_CheckedChanged(object sender, EventArgs e)
        {

            RbAktifPasifYap(rbSnack, cmbSnack);

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            btnAddFood.Enabled = true;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {


            try
            {
                AddedFood _newAddedFood = new AddedFood();

                KullaniciIcinYiyecekEkle(addedFoodRepository, _newAddedFood, cmbBreakfast);
                KullaniciIcinYiyecekEkle(addedFoodRepository, _newAddedFood, cmbLunch);
                KullaniciIcinYiyecekEkle(addedFoodRepository, _newAddedFood, cmbDinner);
                KullaniciIcinYiyecekEkle(addedFoodRepository, _newAddedFood, cmbSnack);

                TextBoxDoldur();
            }
            catch (FormatException fex)
            {
                MessageBox.Show($"Incorrect entry. Just enter numeric value..\n{fex.Message}","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            TextBoxDoldur();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow drow in gdvDaily.SelectedRows)  //Seçili Satırları Silme
            {
                int _seciliID = Convert.ToInt32(drow.Cells[0].Value);
                addedFoodRepository.Sil(db.AddedFoods.Find(_seciliID));
            }
            Listele();
            TextBoxDoldur();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in gdvDaily.SelectedRows)  //Seçili Satırları Silme
                {
                    int _seciliID = Convert.ToInt32(drow.Cells[0].Value);

                    AddedFood _guncellenek = db.AddedFoods.Find(_seciliID);

                    KullaniciIcinYiyecekGuncelle(addedFoodRepository, _guncellenek, cmbBreakfast);
                    KullaniciIcinYiyecekGuncelle(addedFoodRepository, _guncellenek, cmbLunch);
                    KullaniciIcinYiyecekGuncelle(addedFoodRepository, _guncellenek, cmbDinner);
                    KullaniciIcinYiyecekGuncelle(addedFoodRepository, _guncellenek, cmbSnack);
                }
                TextBoxDoldur();
            }
            catch (FormatException fex)
            {
                MessageBox.Show($"Incorrect entry. Just enter numeric value..\n{fex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHaftalikRapor_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_gelenUser);
            form4.Show();
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_gelenUser);
            form5.Show();
        }

        //Metotlar
        private void RbAktifPasifYap(RadioButton radioButton, ComboBox comboBox)
        {


            if (radioButton.Checked)
            {
                comboBox.Enabled = true;
            }
            else
            {
                comboBox.Enabled = false;

            }
        }

        private void TextBoxDoldur()
        {
            txtDailyTotal.Text = ToplamKaloriHesapla().ToString();
            txtTotalCarbo.Text = ToplamCarboHesapla().ToString();
            txtTotalFat.Text = ToplamFatHesapla().ToString();
            txtTotalPro.Text = ToplamProHesapla().ToString();

            txtBFCarbo.Text = ToplamBreakfastCarboHesapla().ToString();
            txtBFFat.Text = ToplamBreakfastFatHesapla().ToString();
            txtBFProtein.Text = ToplamBreakfastProteinHesapla().ToString();
            txtBFKcal.Text = ToplamBreakfastKcalHesapla().ToString();



            txtLCarbo.Text = ToplamLunchCarboHesapla().ToString();
            txtLFat.Text = ToplamLunchFatHesapla().ToString();
            txtLProtein.Text = ToplamLunchProteinHesapla().ToString();
            txtLKcal.Text = ToplamLunchKcalHesapla().ToString();


            txtDinnerCarbo.Text = ToplamDinnerCarboHesapla().ToString();
            txtDinnerFat.Text = ToplamDinnerFatHesapla().ToString();
            txtDinnerProtein.Text = ToplamDinnerProteinHesapla().ToString();
            txtDinnerKcal.Text = ToplamDinnerKcalHesapla().ToString();


            txtSnackCarbo.Text = ToplamSnackCarboHesapla().ToString();
            txtSnackFat.Text = ToplamSnackFatHesapla().ToString();
            txtSnackProtein.Text = ToplamSnackProteinHesapla().ToString();
            txtSnackKcal.Text = ToplamSnackKcalHesapla().ToString();
        }

        #region Breakfast
        public double ToplamBreakfastCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 1).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);

        }
        public double ToplamBreakfastProteinHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 1).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamBreakfastFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 1).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamBreakfastKcalHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 1).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);
        }
        #endregion
        #region Lunch
        public double ToplamLunchCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 2).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        }
        public double ToplamLunchProteinHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 2).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamLunchFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 2).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamLunchKcalHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 2).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);
        }
        #endregion
        #region Dinner
        public double ToplamDinnerCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 3).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        }
        public double ToplamDinnerProteinHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 3).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamDinnerFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 3).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamDinnerKcalHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 3).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);
        }
        #endregion
        #region Snack
        public double ToplamSnackCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 4).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        }
        public double ToplamSnackProteinHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 4).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamSnackFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 4).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamSnackKcalHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today && u.Food.MealID == 4).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);
        }
        #endregion
        #region ToplamHesap
        public double ToplamKaloriHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today).Sum(x => x.CalculatedKcal);
            return Math.Round(toplam, 2);

        }
        public double ToplamProHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today).Sum(x => x.CalculatedProtein);
            return Math.Round(toplam, 2);
        }
        public double ToplamFatHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today).Sum(x => x.CalculatedFat);
            return Math.Round(toplam, 2);
        }
        public double ToplamCarboHesapla()
        {
            var toplam = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today).Sum(x => x.CalculatedCarbo);
            return Math.Round(toplam, 2);
        } 
        #endregion


        public void Listele()
        {
            gdvDaily.DataSource = db.AddedFoods.Where(u => u.UserID == _gelenUser.ID && u.CreatedDate.Date == DateTime.Today).Select(x => new
            {
                x.ID,
                x.Food.Meal.MealType,
                x.Food.FoodName,
                x.CalculatedFat,
                x.CalculatedCarbo,
                x.CalculatedProtein,
                x.CalculatedKcal
            }).OrderBy(x => x.MealType).ToList();


        }

        private void KullaniciIcinYiyecekGuncelle(AddedFoodRepository addedFoodRepository, AddedFood _guncellenecek, ComboBox comboBox)
        {

            if (comboBox.Enabled == true)
            {
                try
                {
                    Food secili = (Food)comboBox.SelectedItem;
                    _guncellenecek.FoodID = secili.ID;

                    _guncellenecek.Quantity = (Convert.ToDouble(txtQuantity.Text) / 100);

                    _guncellenecek.CalculatedCarbo = Math.Round(_guncellenecek.Quantity * secili.CarboValue, 2);

                    _guncellenecek.CalculatedProtein = Math.Round(_guncellenecek.Quantity * secili.ProteinValue, 2);

                    _guncellenecek.CalculatedFat = Math.Round(_guncellenecek.Quantity * secili.FatValue, 2);


                    _guncellenecek.CalculatedKcal = Math.Round(_guncellenecek.Quantity * secili.Kcal, 2);

                    _guncellenecek.UserID = _gelenUser.ID;

                    _guncellenecek.CreatedBy = _gelenUser.FirstName;
                    _guncellenecek.ModifiedBy = _gelenUser.FirstName;
                    _guncellenecek.CreatedDate = DateTime.Today;
                    _guncellenecek.ModifiedDate = DateTime.Today;

                    addedFoodRepository.Guncelle(_guncellenecek);
                    Listele();
                }
                catch (NullReferenceException nex)
                {
                    MessageBox.Show($"Please choose at least one item..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void KullaniciIcinYiyecekEkle(AddedFoodRepository addedFoodRepository, AddedFood _newAddedFood, ComboBox comboBox)
        {

          
            if (comboBox.Enabled == true)
            {
                try
                {
                    Food secili = (Food)comboBox.SelectedItem;
                    _newAddedFood.FoodID = secili.ID;
                    pBoxFood.ImageLocation = secili.Picture;
                    _newAddedFood.Quantity = (Convert.ToDouble(txtQuantity.Text) / 100);

                    _newAddedFood.CalculatedCarbo = Math.Round(_newAddedFood.Quantity * secili.CarboValue, 2);

                    _newAddedFood.CalculatedProtein = Math.Round(_newAddedFood.Quantity * secili.ProteinValue, 2);

                    _newAddedFood.CalculatedFat = Math.Round(_newAddedFood.Quantity * secili.FatValue, 2);


                    _newAddedFood.CalculatedKcal = Math.Round(_newAddedFood.Quantity * secili.Kcal, 2);

                    _newAddedFood.UserID = _gelenUser.ID;

                    _newAddedFood.CreatedBy = _gelenUser.FirstName;
                    _newAddedFood.ModifiedBy = _gelenUser.FirstName;
                    _newAddedFood.CreatedDate = DateTime.Today;
                    _newAddedFood.ModifiedDate = DateTime.Today;

                    addedFoodRepository.Ekle(_newAddedFood);
                    Listele();
                }
                catch (NullReferenceException nex)
                {
                    MessageBox.Show($"Please choose at least one item..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
          



        }
    }
}


