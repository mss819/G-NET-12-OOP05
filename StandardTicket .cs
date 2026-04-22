using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" | Standard | Seat: {Seat}");
        }

        public override object Clone()
        {
            return new StandardTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Seat = this.Seat
            };
        }
    }
}
