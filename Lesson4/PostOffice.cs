using System;
using System.Collections.Generic;

namespace Lesson4
{
    public class PostOffice
    {
        public List<Employee> Employees { get; set; }
        public List<string> Questions { get; set; }

        public PostOffice(List<string> questions, List<Employee> employees)
        {
            Questions = questions;
            Employees = employees;
        }

        public void Poll()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                for (int c = 0; c < Questions.Count; c++)
                {
                    Console.WriteLine(Questions[c]);
                    switch (c)
                    {
                        case 0:
                            Console.WriteLine(Employees[i].SayName());
                            break;
                        case 1:
                            Employees[i].SayActivity();
                            break;
                        case 2:
                            Console.WriteLine(Employees[i].WorkTime());
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}