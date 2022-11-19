using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1
{
    public partial class fLoggins : Form
    {

        public fLoggins()
        {
            InitializeComponent();
        }

        private void fLoggins_Load(object sender, EventArgs e)
        {

        }

      

        private void fLoggins_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo",MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btOut_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btloggin_Click(object sender, EventArgs e)
        {
            string useName = tbUseName.Text;
            string passWord = tbPass.Text;
            if (Login(useName,passWord))
            {
                Account logginAccount = AccountDAO.Instance.GetAcountByUserName(useName);
                fTableManager f = new fTableManager(logginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool Login(string userName,string passWord)
        {

            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}
