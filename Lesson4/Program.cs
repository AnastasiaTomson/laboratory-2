using System;
using System.Collections.Generic;

namespace Lesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> questions  = new List<string>();
            questions.Add("Как вас зовут?");
            questions.Add("Чем вы занимаетесь?");
            questions.Add("Как давно вы здесь работаете?");
            
            List<Employee> employees = new List<Employee>();
            employees.Add(new Cashier() {Name="Таня", StartDate = new DateTime(2018, 10, 21)});
            employees.Add(new Postman() {Name="Света", StartDate = new DateTime(2018, 5, 10)});
            employees.Add(new Cashier() {Name="Таня", StartDate = new DateTime(2017, 11, 12)});
            employees.Add(new Postman() {Name="Никита", StartDate = new DateTime(2019, 3, 7)});
            employees.Add(new Storekeeper() {Name="Борис", StartDate = new DateTime(2018, 1, 12)});
            employees.Add(new Postman() {Name="Юля", StartDate = new DateTime(2016, 11, 1)});
            employees.Add(new Storekeeper() {Name="Саша", StartDate = new DateTime(2019, 6, 6)});
            
            PostOffice postOffice = new PostOffice(questions, employees);
            postOffice.Poll();
        }
    }
}