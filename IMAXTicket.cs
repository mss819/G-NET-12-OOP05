using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" | IMAX | 3D: {(Is3D ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Is3D = this.Is3D
            };
        }
    }
}
