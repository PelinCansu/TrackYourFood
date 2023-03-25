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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void btnEditorGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Editor _editor = db.Editors.Where(x => x.UserName == txtEditorUserName.Text).Single();

                if (_editor.Password == txtEditorPassword.Text)
                {
                    Form7 form7 = new Form7(_editor);
                    form7.ShowDialog();
                }
                else
                {
                    throw new Exception("Şifre Hatalı...");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bilgilerinizi kontrol ederek tekrar giriş yapınız {ex.Message}");
            }


            //Editor _editor = new Editor()
            //{
            //    UserName = txtEditorUserName.Text
            //};

        }
    }
}
