using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public interface IReservation
    {
        string GetDowBooking();
        string GetCodeBooking();
    }

    public class Reservation : IReservation
    {
        private string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string[] days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
        private static Random random = new Random();

        public string Code { get; set; }
        public string Day { get; set; }
        public Reservation()
        {
            Code = GetCodeBooking();
            Day = GetDowBooking();
        }

        public string GetCodeBooking()
        {
            char[] characters = new char[8];
            for (int i = 0; i < 8; i++)
            {
                characters[i] = chars[random.Next(chars.Length)];
            }
            return new string(characters);
        }

        public string GetDowBooking()
        {
            return days[random.Next(days.Length)];
        }
        public void PrintReservation()
        {
            Console.WriteLine("Booking# {0} for {1}",Code,Day);
        }

    }
    class ReservationApp
    {
        static void Main(string[] args)
        {
            Reservation res0 = new Reservation();
            Reservation res1 = new Reservation();
            Reservation res2 = new Reservation();
            Reservation res3 = new Reservation();
            Reservation res4 = new Reservation();
            Reservation res5 = new Reservation();
            Reservation res6 = new Reservation();
            Reservation res7 = new Reservation();

            res0.PrintReservation();
            res1.PrintReservation();
            res2.PrintReservation();
            res3.PrintReservation();
            res4.PrintReservation();
            res5.PrintReservation();
            res6.PrintReservation();
            res7.PrintReservation();
            Console.ReadKey();
        }

    }
}
