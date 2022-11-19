using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
       

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menus> GetListMenuByTable(int id)
        {
            

            string query = "SELECT f.name, bi.count, f.price,f.price*bi.count AS totalPrice  FROM dbo.BillInFo AS bi, dbo.Bill as b, dbo.Food AS f  WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idPhong = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<Menus> listMenu = new List<Menus>();

            foreach (DataRow item in data.Rows)
            {
                
                Menus menu = new Menus(item) ;


                listMenu.Add(menu);
            }

            return listMenu;
        }


    }
}
