using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAT
{
    public class Room
    {
        public Room(int id, string name, string status)
        {
            this.ID = id;
            this.name = name;
            this.status = status;
        }

        public Room (DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private string status;

        private string name;

        private int iD;

        public int ID
        {
            get => iD;
            set => iD = value;
        }


        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Status
        {
                get => status;
                set => status = value;
        }
    }
}


