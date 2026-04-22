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
        }
    }
}
