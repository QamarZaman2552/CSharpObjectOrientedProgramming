using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class StaticAndInstance
    {
    }

    public class Student
    {
        public int id;
        public string? name;
        public static string? Department = "IT";
        public static string? University = "University Of Education";

        public string StudenInfo() {

            return ($"Student Id: {id} \nStudent Name: {name} \nDepartment: {Department} \nUniversity: {University}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Qamar= new Student();
            Qamar.id = 1;
            Qamar.name = "Qamar";
           Console.WriteLine(Qamar.StudenInfo());
            Console.WriteLine("................");
            Student Umar =new Student();
            Umar.StudenInfo();
            Console.WriteLine(Umar.StudenInfo());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
