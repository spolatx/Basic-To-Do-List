using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriOdev
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSifre.Text) && !string.IsNullOrEmpty(TxtKullanici.Text))
            {
                if (DataStore.appUser.Name == TxtKullanici.Text && DataStore.appUser.Password == TxtSifre.Text)
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
              
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
