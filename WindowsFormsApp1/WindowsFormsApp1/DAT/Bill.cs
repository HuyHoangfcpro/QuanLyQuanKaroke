using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAT
{
    public class Bill

    {
        public Bill(int id, DateTime? dataCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;

            this.DataCheckIn = dataCheckIn;

            this.PhongID1 = PhongID1;

            this.DataCheckOut = dataCheckOut;
            
            this.Status = status;


        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DataCheckIn = (DateTime)row["TGvao"];
            this.PhongID1 = (int)row["idPhong"];
            var dateCheckOutTemp = row["TGra"];
            if (dateCheckOutTemp.ToString() != "")
                this.DataCheckOut = (DateTime)dateCheckOutTemp;
            this.Status = (int)row["status"];
        }
        private int PhongID;

        private int status;

        private DateTime? dataCheckIn;

        private DateTime? dataCheckOut;

        private int iD;

        public int ID { get => iD; set => iD = value; }

        public DateTime? DataCheckIn { get => dataCheckIn; set => dataCheckIn = value; }

        public DateTime? DataCheckOut { get => dataCheckOut; set => dataCheckOut = value; }

        public int Status { get => status; set => status = value; }
        public int PhongID1 { get => PhongID; set => PhongID = value; }
    }

}
