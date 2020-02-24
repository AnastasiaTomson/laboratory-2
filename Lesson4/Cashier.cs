using System;

namespace Lesson4
{
    public class Cashier : Employee
    {
        public override string Name { get; set; }
        public override DateTime StartDate { get; set; }

        public override void SayActivity()
        {
            Console.WriteLine("Обслуживаю посетителей");
        }

        public override int WorkTime()
        {
            return (DateTime.Now.Date - StartDate.Date).Days;
        }
    }
}