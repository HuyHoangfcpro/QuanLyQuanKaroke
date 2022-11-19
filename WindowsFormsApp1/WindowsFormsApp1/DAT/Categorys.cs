using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAT
{
     public class Categorys
    {
        public Categorys(int id , string name)
        {
            this.ID = id;
            this.Name = name;
        }
        
        public Categorys(DataRow row )
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }

        private string name;

        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
