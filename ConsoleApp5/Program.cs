using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "student information"+"\t" );
            
            student s = new student(" rand", 3);
            Console.WriteLine("student Name: "+s.Name+"\t"+" level: "+s.Level);


            Console.WriteLine("\t" + "teacher information"+"\t" );
            teacher t = new teacher("noor");
            t.print();

            Console.WriteLine(s.Name+ "\t"+ "Grade:");
            t.studentGrade(30);

            t.studentGrade();








        }
    }
}
