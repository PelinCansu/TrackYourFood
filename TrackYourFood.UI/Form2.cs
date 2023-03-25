using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackYourFood.BLL.Concrete;
using TrackYourFood.Entites.Concrete;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrackYourFood.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();

            User _newUser = new User();

            try
            {
                _newUser.FirstName = txtFirstName.Text;
                _newUser.LastName = txtLastName.Text;
                _newUser.Email = txtEmail.Text;

                if (txtPassword.Text == txtPasswordCorrection.Text)
                {
                    _newUser.Password = txtPassword.Text;
                }
                _newUser.CreatedBy = $"{txtFirstName.Text} {txtLastName.Text}";
                _newUser.ModifiedBy= $"{txtFirstName.Text} {txtLastName.Text}";
                _newUser.CreatedDate = DateTime.Now;
                _newUser.ModifiedDate = DateTime.Now;

                userRepository.Ekle(_newUser);
                MessageBox.Show("Sign up is OK.");
            
                this.Close();

            }

            //catch (FormatException fex)
            //{
            //    MessageBox.Show(fex.Message);

            //}
   
            //catch (DuplicateNameException dex)
            //{
            //    MessageBox.Show($"Bu email ile daha önce giriş yapıldı. {dex.Message}");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Information";
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 3000;

            toolTip1.SetToolTip(this.txtPassword, "Password must\n * Have at least 1 letter.\n * Have at least 1 number.\n * Have at least 1 punctuation mark. ");

            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Information";
            toolTip2.AutomaticDelay = 100;
            toolTip2.AutoPopDelay = 3000;
                   
            toolTip2.SetToolTip(this.txtPasswordCorrection, "Password must confirm.");
        }
    }
}
