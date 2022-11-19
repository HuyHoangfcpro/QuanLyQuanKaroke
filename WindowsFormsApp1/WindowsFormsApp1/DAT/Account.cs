using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAT
{
    public  class Account
    {
        public Account(string useName, string displayName, int type, string passWord = null)
        {
            this.UseName = useName;
            this.Type = type;
            this.DisplayName = displayName;
            this.PassWord = passWord;

        }

        public Account(DataRow row)
        {
            this.UseName = row["useName"].ToString();
            this.Type = (int)row["type"];
            this.DisplayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
        }


        private string useName; 
        private string displayName;
        private string passWord;
        private int type;

        public string UseName { get => useName; set => useName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
    }
}
