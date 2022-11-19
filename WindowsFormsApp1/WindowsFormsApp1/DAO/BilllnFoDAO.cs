using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
     public class BilllnFoDAO
    {
        private static BilllnFoDAO instance;

        public static BilllnFoDAO Instance
        {
            get { if (instance == null) instance = new BilllnFoDAO(); return instance; }
            private set { BilllnFoDAO.instance = value; }
        }
        private BilllnFoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT *  FROM dbo.BillInFo WHERE idBill = "+ id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExcuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
