using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackYourFood.Entites.Concrete;

namespace TrackYourFood.UI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Editor _gelenEditor;
        public Form7(Editor gelenEditor)
        {
            _gelenEditor = gelenEditor;
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(_gelenEditor);
            form8.Show();
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(_gelenEditor);
            form9.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(_gelenEditor);
            form10.Show();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(_gelenEditor);
            form11.Show();

        }


        private void Form7_Load(object sender, EventArgs e)
        {
            txtEditorWelcome.Text = $"Welcome Dear Colleague, {_gelenEditor.UserName}";
        }

        private void btnUserStatistics_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(_gelenEditor);
            form12.Show();
        }
    }
}
