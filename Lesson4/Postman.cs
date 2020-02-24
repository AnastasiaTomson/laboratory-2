using System;

namespace Lesson4
{
    public class Postman : Employee
    {
        public override string Name { get; set; }
        public override DateTime StartDate { get; set; }

        public override void SayActivity()
        {
            Console.WriteLine("Разношу почту");
        }

        public override int WorkTime()
        {
            return (DateTime.Now.Date - StartDate.Date).Days;
        }
    }
}