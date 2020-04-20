using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolapp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Addmission_btn_Click(object sender, EventArgs e)
        {
            studentAddmission student = new studentAddmission();
            student.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            Show_Pannel.Controls.Add(search);
        }
    }
}
