using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp5
{
    public class student
    {
        private string name;
        private int level;

        public student(string name, int level)
        {
            this.name = name;
            this.level = level;

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;///نسبة المتوسط الحسابي
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {

                this.level = value;
            }
        }
    }
    public class teacher
    {
        private string name;
        private int age;
        public teacher(string name)
        {
            this.name = name;
            
        }

        public void studentGrade(int g)
        {
            //g = Console.ReadLine();

            if (g<100 && g>90)
            Console.WriteLine("\t" + "A");
            else if (g < 90 && g > 80)
                Console.WriteLine("\t" + "B");
            else if (g < 80 && g > 70)
                Console.WriteLine("\t" + "c");

            else if (g < 70 && g > 60)
                Console.WriteLine("\t" + "D");
            else
            {
                Console.WriteLine("\t" + "F");
            }
        }
        public void studentGrade()
        {
                Console.WriteLine("No Grade");
        }


        public string Name
        {
            get {
                return name;
            }

            set {
                this.name = value;
            
            }


        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                this.age = value;

            }


        }

        public void print()
        {
            Name = "faten";
            Age = 25;
                Console.WriteLine("teacher Name: " + Name + "\t" + " Age: " +Age);
        }





    }





}
