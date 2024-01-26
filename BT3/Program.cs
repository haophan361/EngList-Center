using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hotel=new Hotel();
            hotel.AddRoom(new StandardRoom(101));
            hotel.AddRoom(new SuiteRoom(102));
            hotel.BookRoomForDate(101, DateTime.Today);
            hotel.BookRoomForDate(102,DateTime.Today);
            hotel.CleanRoom();
            Console.ReadKey();
        }
    }
}