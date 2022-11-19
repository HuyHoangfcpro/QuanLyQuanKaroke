using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;


        public static  AccountDAO Instance
        {
            get { if (instance == null)  instance = new AccountDAO();  return instance;  }
            private set { instance = value; }
        }


        private AccountDAO() { }
        public bool Login(string userName , string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }


        public bool UpdateAccount(string useName,string displayName,string passWord ,string newpass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @useName , @displayName , @password , @newPassword ", new object[]{useName,displayName,passWord,newpass});

            return result > 0;
        }
        public Account GetAcountByUserName(string useName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select *from account where UseName = '" + useName+ "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }
            return null;
        }

    }
   
}
