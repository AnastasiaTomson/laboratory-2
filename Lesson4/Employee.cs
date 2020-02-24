using System;

namespace Lesson4
{
    public abstract class Employee
    {
        public abstract string Name { get; set; }
        public abstract DateTime StartDate { get; set; }

        public virtual string SayName()
        {
            return Name;
        }

        public abstract void SayActivity();
        public abstract int WorkTime();
    }
}