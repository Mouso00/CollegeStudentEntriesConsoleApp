using CollegeStudentEntriesConsoleApp.Models;
using System.Diagnostics.Metrics;
using System.Diagnostics;


namespace CollegeStudentEntriesConsoleApp
{
    class Program
    {
        public static List<Student> studentList { get; set; } = new List<Student>();
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = mainMenu();
            }
        }
        private static bool mainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Add new student Entry : ");
            Console.WriteLine("4) Show student entries: ");
            Console.WriteLine("7) To Exit the program: ");
            Console.WriteLine("\r\n Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    captureStudentInput();
                    return true;
                case "2":
                    return true;
                case "3":

                    return true;
                case "4":
                    showcapturedStudentInput();
                    return true;
                case "5":

                    return true;
                case "6":

                    return true;
                case "7":

                    return false;
                default:
                    return true;
            }

        }
        public static void captureStudentInput()
        {

            Console.Clear();

            Student student= new Student();
            
            Console.WriteLine("Insert Student Name");
            var name = Console.ReadLine();
            student.name = name;

            studentList.Add(student);

        }
        public static void showcapturedStudentInput()
        {
            Console.Clear();
            foreach(var student in studentList)
            {
                string name = student.name;
                Console.WriteLine("The student name is: " + name);

            }
            Console.ReadKey();

        }


    }
   
}