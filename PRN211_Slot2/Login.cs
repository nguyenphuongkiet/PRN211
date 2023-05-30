using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Slot2
{
    public partial class Login : Form
    {
        BankAccountRepository bankAccount;
        UserRepository userRepository;
        public Login()
        {
            InitializeComponent();
            bankAccount = new BankAccountRepository();
            userRepository = new UserRepository();      
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var check = userRepository.GetAll().FirstOrDefault(a => a.UserName == username && a.Password == password && a.UserRole.Value == 1);
            if (check != null)
            {
                //dang nhap thanh cong
                //MessageBox.Show("Dang nhap thanh cong","Thong bao",MessageBoxButtons.OK);
                this.Hide();
                Form frManagement = new Management();
                frManagement.ShowDialog();
            }
            else
            {
                //dang nhap that bai
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK);
            }
            btnLogin.Enabled = true;
        }
    }
}
