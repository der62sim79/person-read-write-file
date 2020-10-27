using Logic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MyFirstCSharpApp
{
    class Program
    {

        static void Main(string[] args)
        {
            String[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\Downloads\\persons.txt");
            String[] txtPeson;
            List<Person> people = new List<Person>();


            foreach(String per in myFileContent)
            {

                txtPeson = per.Split(";");

                Person person = new Person();
                person.name = txtPeson[0];
                person.age = int.Parse(txtPeson[1]);
                person.city = txtPeson[2];

                if (person.name.StartsWith("H"))
                {
                    person.job = "Coder";
                }
                else
                {
                    person.job = "Officer";
                }

                people.Add(person);

                
                Console.WriteLine("name: " + person.name + " age: " + person.age + " city: " + person.city + " job: " + person.job);


                String[] lines = GetArrayOfPeople(people);
                System.IO.File.WriteAllLines(@"C:\Users\DCV\Desktop\persons1.txt", lines);
            }
        }

        private static String[] GetArrayOfPeople(List<Person> people)
        {
            String[] peopleStr = new string[people.Count];
            for (int i = 0; i < people.Count; i++)
            {
                String person = people[i].toString();
                peopleStr[i] = person;
            }
            return peopleStr;
        }
    }
}
