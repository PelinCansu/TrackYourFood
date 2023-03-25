using Microsoft.EntityFrameworkCore;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Editor _gelenEditor;
        public Form8(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }

        CategoryRepository categoryRepository = new CategoryRepository();
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category _eklenecek = new Category()
            {
                CategoryName = txtCatName.Text,
                CreatedBy = _gelenEditor.UserName,
                ModifiedBy = _gelenEditor.UserName,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            
            };
            categoryRepository.Ekle(_eklenecek);
            dgvCategory.DataSource = categoryRepository.GetByAll();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int _seciliID = Convert.ToInt32(dgvCategory.SelectedRows[0].Cells[0].Value);
            categoryRepository.Sil(db.Categories.Find(_seciliID));
            //foreach (DataGridViewRow drow in dgvCategory.SelectedRows)  //Seçili Satırları Silme
            //{
            //}
            dgvCategory.DataSource = categoryRepository.GetByAll();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource= categoryRepository.GetByAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int _seciliKategoriId =Convert.ToInt32(dgvCategory.SelectedRows[0].Cells[0].Value);
                
            Category _guncellenek = db.Categories.Find(_seciliKategoriId);
            _guncellenek.CategoryName = txtCatName.Text;
            
            categoryRepository.Guncelle(_guncellenek);

            dgvCategory.DataSource = categoryRepository.GetByAll();


        }
    }
}
