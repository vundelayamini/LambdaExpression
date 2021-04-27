using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expressions:");
            List<Person> list = new List<Person>();
            AddingpersonDetails(list);
            IterateOverList(list);

        }
        //UC1-person management
        public static void AddingpersonDetails(List<Person> personlist)
        {
            personlist.Add(new Person() { SSN = 1, Age = 16, Name = "yamini", Address = "Banglore" });
            personlist.Add(new Person() { SSN = 4, Age = 22, Name = "Amani", Address = "Banglore" });
            personlist.Add(new Person() { SSN = 5, Age = 65, Name = "Lakshmi", Address = "Hyderabad" });
            personlist.Add(new Person() { SSN = 1, Age = 32, Name = "Priya", Address = "Manglore" });
            personlist.Add(new Person() { SSN = 2, Age = 23, Name = "Mahi", Address = "Chennai" });
            personlist.Add(new Person() { SSN = 7, Age = 24, Name = "Jhanu", Address = "Mumbai" });
            personlist.Add(new Person() { SSN = 3, Age = 35, Name = "gayi", Address = "Banglore" });
        }
        public static void IterateOverList(List<Person> personlist)
        {
            try
            {

                foreach (Person person in personlist)
                {
                    Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address + "\t");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
    
}
