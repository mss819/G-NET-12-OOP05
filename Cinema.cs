using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void Close()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void Add(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("\n--- All Tickets ---");
            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();
            }
        }
    }
}
