using System;

namespace Lesson4
{
    public class Storekeeper : Employee
    {
        public override string Name { get; set; }
        public override DateTime StartDate { get; set; }

        public override void SayActivity()
        {
            Console.WriteLine("Ищу посылку");
        }

        public override int WorkTime()
        {
            return (DateTime.Now.Date - StartDate.Date).Days;;
        }
    }
}