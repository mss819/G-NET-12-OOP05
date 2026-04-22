using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public class VIPTicket : Ticket
    {
        public bool Lounge { get; set; }
        public double Fee { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" | VIP | Lounge: {(Lounge ? "Yes" : "No")} | Fee: {Fee}");
        }

        public override object Clone()
        {
            return new VIPTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Lounge = this.Lounge,
                Fee = this.Fee
            };
        }
    }
}
