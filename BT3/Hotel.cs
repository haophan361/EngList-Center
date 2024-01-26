using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class Hotel
    {
        private List<Room> rooms;
        public Hotel() 
        {
            rooms = new List<Room>();
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public bool BookRoomForDate(int roomNumber,DateTime date)
        {
            var room= rooms.FirstOrDefault(r =>r.Number == roomNumber);
            if(room !=null)
            {
                return room.BookRoom(date);
            }
            return false;
        }
        public void CleanRoom()
        {
            foreach(var room in rooms)
            {
                room.CleanRoom();
            }
        }
    }
}
