namespace G_NET_12_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //عقد (Contract) بيحدد methods بس من غير implementation
            //بيساعد في Polymorphism
            //بيخلي الكود قابل للتطوير والتعديل بسهولة

            #endregion

            #region Question 2

            //الكلاس عامل method واحدة:
            // علشان كد مش مفرق بين الانجليزي و العربي 
            // الحل
            //    class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    void IEnglishSpeaker.Greet()
            //    {
            //        Console.WriteLine("Hello");
            //    }

            //    void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine("Ahlan");
            //    }
            //}
            //c) لازم 
            //((IEnglishSpeaker)translator).Greet();
            //((IArabicSpeaker)translator).Greet();

            #endregion

            #region Question 3

            //Shallow Copy
            //بينسخ القيم بس
            //الـ reference بيبقى مشترك

            //Deep Copy
            //بينسخ object كامل (نسخة مستقلة)

            #endregion

            #region Question 4

            //var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //var e2 = e1.ShallowCopy();

            //e2.Title = "QA";
            //e2.Dept.Name = "Testing";

            //Title → Value → اتغير في e2 بس
            //Dept → Reference → الاتنين بيشاوروا على نفس object
            #endregion

            #region Part02

            Cinema c = new Cinema();
            c.Open();

            var t1 = new StandardTicket { MovieName = "Inception", Price = 80, Seat = "A5" };
            var t2 = new VIPTicket { MovieName = "Avengers", Price = 200, Lounge = true, Fee = 50 };
            var t3 = new IMAXTicket { MovieName = "Dune", Price = 130, Is3D = true };

            t1.Book();
            t2.Book();
            t3.Book();

            c.Add(t1);
            c.Add(t2);
            c.Add(t3);

            c.PrintAll();

            // Clone
            Console.WriteLine("\n--- Clone Test ---");
            var clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original : "); t2.Print();
            Console.Write("Clone    : "); clone.Print();

            // Cancel
            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            // Interface Polymorphism
            BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });



            #endregion
        }
    }
}
