using System;
using System.IO;

namespace Day01TextFile{
    class Program
    {
        static List<Person> people = new List<Person>();
        static string filePath = @"./data.txt";

        static void Main(string[] args) {
            
            bool fileIsExist = File.Exists(filePath);
            if (fileIsExist)
            {
                Console.WriteLine("What do you want to do ? \n" +
                    "1. Add person info \n" +
                    "2. List persons info \n" +
                    "3. Find a person by name \n" +
                    "4. Find all persons younger than age \n" +
                    "0. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPersonInfo();
                        break;
                    case "2":
                        ListAllPersonInfo();
                        break;
                    case "3":
                        Console.WriteLine("choice 3");
                        break;
                    case "4":
                        Console.WriteLine("choice 4");
                        break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("No file Exist");
            }
          
        }


        static void ReadAllPeopleFromFile(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            Console.WriteLine(readAllText);
            Console.ReadKey();
        }

        static void SaveAllPeopleToFile()
        {
            var lines = new List<string>();
            lines.Add("A");
            lines.Add("B");
            lines.Add("C");
            File.WriteAllLines(filePath, lines);
        }

        static void AddPersonInfo()
        {
            Console.WriteLine("Adding a person.");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            string ageStr = Console.ReadLine();
            if (!int.TryParse(ageStr, out int age))
            {
                Console.WriteLine("Please enter valid age format");
            }
            
            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            people.Add(new Person(name, age, city));
        }

        static void ListAllPersonInfo()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        static void FindPersonByName()
        {

        }

        static void FindPersonYoungerThan(int age)
        {

        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public string ToString()
        {
            return string.Format("{0} is {1} y/o from {2}.", Name, Age, City);
        }
    }

}