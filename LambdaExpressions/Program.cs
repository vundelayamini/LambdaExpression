using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expressions");
            List<Person> list = new List<Person>();
            AddingpersonDetails(list);
            //RetrieveTop2Records(list);
            //RetrieveTeenageRecords(list);
            //FindAvgAgeForAll(list);
            // SearchPerson(list);
           // SkipLessThan60(list);
            RemovePerson(list);

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
            //IterateOverList(personlist);

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        //UC2 Retrieve top two records from the list for age less than 60
        public static void RetrieveTop2Records(List<Person> list)
        {
            var result = list.FindAll(x => x.Age < 60).OrderBy(x => x.Age).Take(2);
            foreach (Person person in result)
            {
                Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
            }
        }
        //UC3 Retrieve all record from the list for age between 13 to 18 or less 
        public static void RetrieveTeenageRecords(List<Person> list)
        {
            try
            {
                var result = list.FindAll(x => x.Age < 13 && x.Age < 18);
                foreach (Person person in result)
                {
                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //UC4-Retrive Average age in the list
        public static void FindAvgAgeForAll(List<Person> list)
        {
            try
            {
                var result = list.Average(x => x.Age);
                Console.WriteLine("Average age among all person  : \t" + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //UC5 Search for specific name present in the list or not
        public static Person SearchPerson(List<Person> list, string name)
        {
            try
            {
                var person = list.Where(n => n.Name == "Jhanu").FirstOrDefault();
                if (person != null)
                {
                    Console.WriteLine("Person present");
                    Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address + "\t");
                    return person;
                }
                else
                {
                    Console.WriteLine("person not exist in the list");
                    return null;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //UC6-skip record from the list for age is lessthan 60
        public static void SkipLessThan60(List<Person> list)
        {
            var result = list.FindAll(x => x.Age > 60);
            foreach (Person person in result)
            {
                Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address + "\t");

            }
        }

        //UC7-Remove specific name from the list
        public static void RemovePerson(List<Person> list)
        {
            var remove = SearchPerson(list, "Mahi");
            bool result = false;
            if (remove != null)
            {
                result = list.Remove(remove);
                //Console.WriteLine("Removed successfully.");
            }
            if (result)
            {
                Console.WriteLine("Removed Successfully");
            }
            else
            {
                Console.WriteLine("not Removed");
            }
        }
       




    }
}





