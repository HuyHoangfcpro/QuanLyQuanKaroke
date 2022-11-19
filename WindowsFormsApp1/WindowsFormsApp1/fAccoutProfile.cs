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
    public partial class fAccoutProfile : Form
    {
        private Account logginAccount;

        public Account LogginAccount
        {
            get { return logginAccount; }
            set { logginAccount = value; ChangeAccount(logginAccount); }
        }

        public fAccoutProfile(Account acc)
        {
            InitializeComponent();
            LogginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            tbtenDangNhap.Text = LogginAccount.UseName;
            tbhienthi.Text = LogginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = tbhienthi.Text;
            string passWord = tbpassword.Text;
            string newpass = tbpwnew.Text;
            string nhaplaipass = tbnhapLai.Text;
            string useName = tbtenDangNhap.Text;

            if (!newpass.Equals(nhaplaipass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");

            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(useName,displayName,passWord,newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent (AccountDAO.Instance.GetAcountByUserName(useName)));
                }
                else
                {
                    MessageBox.Show("Vui điền đúng mật khẩu");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc { get => acc; set => acc = value; }

            public AccountEvent (Account acc)
            {
                this.Acc = acc;
            }
        }

    }
}
