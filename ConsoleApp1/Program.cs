using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve Soyadinizi daxil edin");

            string fullname = Console.ReadLine();

            Console.WriteLine("Group Nomrenizi Daxil Edin");

            string groupno = Console.ReadLine();
            
            Student stu = new Student(fullname, groupno);

            Console.WriteLine(Student.GroupFullNameNumber);
            
        }
    }
}
