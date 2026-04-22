using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 0;

        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }

        public bool IsBooked { get; private set; }

        public double PriceAfterTax => Price * 1.14;

        public Ticket()
        {
            counter++;
            TicketId = counter;
        }

        // Booking
        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        // Printable
        public virtual void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        // Clone (Deep Copy)
        public abstract object Clone();
    }
}
