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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        Editor _gelenEditor;
        public Form10(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }
        UnitRepository unitRepository = new UnitRepository();
        TrackYourFoodContext db = new TrackYourFoodContext();


        private void btnListele_Click_1(object sender, EventArgs e)
        {
            dgvEditorUnit.DataSource = unitRepository.GetByAll();

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Unit _eklenecek = new Unit()
            {
                NameOfUnit = txtUnitName.Text,
                CreatedBy = _gelenEditor.UserName,
                ModifiedBy = _gelenEditor.UserName,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now

            };
            unitRepository.Ekle(_eklenecek);
            dgvEditorUnit.DataSource = unitRepository.GetByAll();

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int _seciliID = Convert.ToInt32(dgvEditorUnit.SelectedRows[0].Cells[0].Value);
            unitRepository.Sil(db.Units.Find(_seciliID));
            //foreach (DataGridViewRow drow in dgvCategory.SelectedRows)  //Seçili Satırları Silme
            //{
            //}
            dgvEditorUnit.DataSource = unitRepository.GetByAll();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int _seciliKategoriId = Convert.ToInt32(dgvEditorUnit.SelectedRows[0].Cells[0].Value);

            Unit _guncellenecek = db.Units.Find(_seciliKategoriId);
            _guncellenecek.NameOfUnit = txtUnitName.Text;

            unitRepository.Guncelle(_guncellenecek);

            dgvEditorUnit.DataSource = unitRepository.GetByAll();
        }
    }
}
