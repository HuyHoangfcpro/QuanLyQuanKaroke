using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAT
{
    public class Food
    {
        private int iD;

        private string name;

        private int CategoryID;

        private float price;

        public Food(int id, string name, int categoryiD,float price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.CategoryID1 = CategoryID;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name =row["name"].ToString();
            this.Price =(float)Convert.ToDouble(row["price"].ToString());
            this.CategoryID1 =(int)row ["idCategory"];
        }



        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
 
        public float Price { get => price; set => price = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
    }
}
