using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3_Ex2
{
    abstract class Student
    {
        public string _name;
        public string state;
        public Student(string name)
        {
            _name = name;
            state = "";
        }
        public void Relax()
        {
            state = "Relax";
        }
        public void Read()
        {
            state = "Read";
        }
        public void Write()
        {
            state = "Write";
        }
        abstract public void Study();
    }

    internal class GoodStudent : Student
    {
        public GoodStudent(string name) : base (name)
        {
            state += "good";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    internal class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state += "bad";
        }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Relax();
        }
    }

    class Group
    {
        string groupName;
        List<Student> list = new List<Student>();

        public Group(string name)
        {
            groupName = name;
        }
        public string Name()
        {
            return groupName;
        }
        public void AddStudent(Student st)
        {
            list.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(groupName);
            for(int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]._name);
            }
            Console.WriteLine("==============================");
        }

        public void GetFullInfo()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(groupName);
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]._name + "   " + list[i].state + "   student");
            }
            Console.WriteLine("==============================");

        }

        
    }

    class Program
    {

        //Метод, що вводить інформацію про групи
        static void WriteInfo(int numberGroup, ref Group[] groups)
        {
            for (int j = 0; j < numberGroup; j++)
            {
                Console.WriteLine("Write a name of the group");
                groups[j] = new Group(Console.ReadLine());

                Console.WriteLine("How many students are in this group?");
                int students;
                bool indicator = int.TryParse(Console.ReadLine(), out students);
                while (students <= 0 || indicator == false)
                {
                    Console.WriteLine("The number is incorrect. Try again");
                    indicator = int.TryParse(Console.ReadLine(), out students);
                }

                Console.WriteLine("How many good students are in this group?");
                int goodstudents;
                indicator = int.TryParse(Console.ReadLine(), out goodstudents);
                while (goodstudents <= 0 || indicator == false)
                {
                    Console.WriteLine("The number is incorrect. Try again");
                    indicator = int.TryParse(Console.ReadLine(), out goodstudents);
                }
                Console.WriteLine("Write names of good students");
                for (int i = 0; i < goodstudents; i++)
                {
                    groups[j].AddStudent(new GoodStudent(Console.ReadLine()));
                }

                Console.WriteLine("Write names of bad students");
                for (int i = 0; i < students - goodstudents; i++)
                {
                    groups[j].AddStudent(new BadStudent(Console.ReadLine()));
                }
                Console.WriteLine("");
            }
        }


        ///Метод, що ви водить інформацію про групи
        static void Print(int numberGroup, ref Group[] groups)
        {
            string answer = "yes";
            while (answer != "no")
            {
                Console.WriteLine("Do you wanna get info about any of groups?");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        {
                            Console.WriteLine("About which one? Write the group name");
                            string gname = Console.ReadLine();
                            for (int j = 0; j < numberGroup; j++)
                            {
                                if (gname == groups[j].Name())
                                {
                                    Console.WriteLine("Do you wanna get full or just info?");
                                    switch (Console.ReadLine())
                                    {
                                        case "full":
                                            {
                                                groups[j].GetFullInfo();
                                                break;
                                            }
                                        case "just":
                                            {
                                                groups[j].GetInfo();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Write the correct answer");
                                                break;
                                            }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    case "no":
                        {
                            Console.WriteLine("Goodbye, have a good day!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Write the correct answer");
                            break;
                        }
                }
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("How many groups?");
            int numberGroup;
            bool indicator = int.TryParse(Console.ReadLine(), out numberGroup);
            while (numberGroup <= 0 || indicator == false)
            {
                Console.WriteLine("The number is incorrect. Try again");
                indicator = int.TryParse(Console.ReadLine(), out numberGroup);
            }
            Console.WriteLine("");


            Group[] groups = new Group[numberGroup];

            WriteInfo(numberGroup,ref groups);

            Print(numberGroup, ref groups);


        }
    }
}
