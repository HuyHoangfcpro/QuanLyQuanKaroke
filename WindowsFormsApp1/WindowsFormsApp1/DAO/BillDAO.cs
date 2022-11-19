using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
 

        public static BillDAO Instance
        {
            
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }

            private set { BillDAO.instance = value; } 
        }
        private BillDAO() { }

        /// <summary>
        /// thành công: bill ID 
        /// thất bại : -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public int GetUnChekBillIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE idPhong = "+ id + " AND status = 0");

            if (data.Rows.Count> 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;            
        
        }
        public void CheckOut(int id, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET TGra = GETDATE(), status = 1,"  + "totalPrice = " + totalPrice  +  " WHERE id =" + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("exec USP_InsertBill @idPhong", new object[]{id});
        }
        public DataTable GetBillListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
            
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
            
        }
    }
}
