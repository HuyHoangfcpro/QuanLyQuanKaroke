using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DAT;
using static System.Windows.Forms.ListViewItem;
//using Menu = WindowsFormsApp1.DAT.Menu;

namespace WindowsFormsApp1
{
    public partial class fTableManager : Form
    {
        private Account logginAccount;

        public Account LogginAccount
        {
            get { return logginAccount; }
            set { logginAccount = value; ChangeAccount(logginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LogginAccount= acc;

            LoadRoom();

            LoadCatetegory();


        }


        #region Method
        void ChangeAccount(int type)
        {
            aDMINToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LogginAccount.DisplayName + ")";

        }


        void LoadCatetegory()
        {
            List<Categorys> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCatoryID(int id)
        {

            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";

        }
        void LoadRoom()
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };

                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }


                flpRoom.Controls.Add(btn);

            }
        }

        void ShowBill(int id)
        {
            lsvBilll.Items.Clear();
            List<Menus> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
             foreach (Menus item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());

                lsvItem.SubItems.Add((item.Count.ToString()));

                lsvItem.SubItems.Add((item.Price. ToString()));

                lsvItem.SubItems.Add((item.TotalPrice.ToString()));
                totalPrice += item.TotalPrice;

                lsvBilll.Items.Add(lsvItem);

                
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            

            txbTotolPrice.Text = totalPrice.ToString("c",culture);

            LoadRoom();
            
        }


        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int RoomID = ((sender as Button).Tag as Room).ID;
            lsvBilll.Tag = (sender as Button).Tag;
            ShowBill(RoomID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccoutProfile f = new fAccoutProfile(LogginAccount);
            f.UpdateAccount += F_UpdateAccount;  ;
            f.ShowDialog();
        }

        private void F_UpdateAccount(object sender, fAccoutProfile.AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }
     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
       

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Categorys selected = cb.SelectedItem as Categorys ;

            id = selected.ID;
            
            LoadFoodListByCatoryID(id);

        }

        private void btThemDV_Click(object sender, EventArgs e)
        {
            Room room = lsvBilll.Tag as Room;

            int idBill = BillDAO.Instance.GetUnChekBillIDByRoomID(room.ID);

            int foodID = (cbFood.SelectedItem as Food).ID;

            int count = (int)nmFoodCount.Value;

            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(room.ID);

                BilllnFoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(),foodID,count);
            }
            else
            {
                BilllnFoDAO.Instance.InsertBillInfo( idBill, foodID, count);
            }
            ShowBill(room.ID);

            
        }
        private void btCheckOut_Click(object sender, EventArgs e)
        {
            Room room = lsvBilll.Tag as Room;

            int idBill = BillDAO.Instance.GetUnChekBillIDByRoomID(room.ID);

            double totalPrice = Convert.ToDouble(txbTotolPrice.Text.Split(',')[0]);

            double giaTriThuc = totalPrice ;

            

            if (idBill != -1)
            {
                if(MessageBox.Show("bạn có chắc muốn thanh toán đơn cho bàn"+room.Name,"Thông Báo",MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,(float)giaTriThuc);
                    ShowBill(room.ID);
                }
            }
        }

        #endregion

        private void txbTotolPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
