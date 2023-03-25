using TrackYourFood.BLL.Concrete;
using TrackYourFood.DAL;

namespace TrackYourFood.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Information";
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 3000;

            toolTip1.SetToolTip(this.txtUserName, "Please enter a confirmed email address.");
        }

        private void linkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.Show();
            
        }
        UserRepository userRepository = new UserRepository();
        TrackYourFoodContext db = new TrackYourFoodContext();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var _user = db.Users.Where(x => x.Email == txtUserName.Text).Single();

                if(_user.Password== txtPassword.Text)
                {
                    Form3 form3 = new Form3(_user);
                    form3.ShowDialog();
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bilgilerinizi kontrol ederek tekrar giriþ yapýnýz {ex.Message}");
            }
        }

        private void linkLabelEditor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}