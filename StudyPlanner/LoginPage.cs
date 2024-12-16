using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPlanner
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi username dan password
            if (UsernameTxt.Text == "bukanadmin" && PassTxt.Text == "IniPassword")
            {
                // Jika valid, buka form jadwal
                Form1 mainForm = new Form1(); // Asumsikan form input jadwal bernama MainForm
                mainForm.Show();
                this.Hide(); // Sembunyikan form login
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            // Menggunakan sensor default untuk password
            PassTxt.UseSystemPasswordChar = true;
        }
    }
}
