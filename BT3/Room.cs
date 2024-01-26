using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public abstract class Room:ICleanable,IBookable
    {
        public int Number {  get; set; }
        protected Dictionary<DateTime, bool> bookingCalendar;
        protected Room(int number)
        {
            Number = number;
            bookingCalendar = new Dictionary<DateTime, bool>();
        }
        public virtual bool BookRoom (DateTime date)
        {

            if (bookingCalendar.TryGetValue(date,out bool isBooked) && !isBooked)
            {
                bookingCalendar[date] = true;
                return true;
            }
            return false;
        }
        public void ReleaseRoom(DateTime date)
        {
            if(bookingCalendar.ContainsKey(date))
            {
                bookingCalendar[date] = false;
            }
        }
        public abstract void CleanRoom();
    }
}
