using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            Loading();

        }
        #region methods
        void Loading()
        {
            LoadAccountList();
            LoadFoodList();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkDau.Value, dtpkCuoi.Value);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkDau.Value = new DateTime(today.Year, today.Month, 1);
            dtpkCuoi.Value = dtpkDau.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListBillByDate(checkIn, checkOut);
        }

        #endregion

        void LoadFoodList()
        {
            string query = "select * from Food";
            dtvgFood.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { AllowDrop });
        }
        void LoadRoomList()
        {
            string query = " select * from Phong";
            dtvgRoom.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { AllowDrop });
        }
        void LoadAccountList()
        {

            string query = "EXEC dbo.USP_GetAccountByUserName @userName  ";



            dtvgAccount.DataSource = DataProvider.Instance.ExcuteQuery(query, new object[] { "vip" });

        }

        private void btviewBIll_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkDau.Value, dtpkCuoi.Value);
        }


        #region events
        #endregion



        private void dtvgFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}