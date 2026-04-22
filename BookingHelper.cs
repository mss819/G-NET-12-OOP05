using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    public static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
