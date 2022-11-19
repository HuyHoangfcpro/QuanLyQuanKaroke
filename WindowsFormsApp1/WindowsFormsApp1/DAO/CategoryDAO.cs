using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
     public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO()
        {

        }

        public List<Categorys> GetListCategory()
        {
            List<Categorys> list = new List<Categorys>();

            string query = "select * from FoodCategory ";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Categorys categorys = new Categorys(item);

                list.Add(categorys);

            }

            return list;
        }
          

          
    }
}
