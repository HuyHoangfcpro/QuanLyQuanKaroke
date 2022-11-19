using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAT;

namespace WindowsFormsApp1.DAO
{
    class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance

        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }

            private set { RoomDAO.instance = value; }
        }

        public static int RoomWidth = 90;
        public static int RoomHeight = 90;

        private RoomDAO() { }

        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetRoomList");

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
