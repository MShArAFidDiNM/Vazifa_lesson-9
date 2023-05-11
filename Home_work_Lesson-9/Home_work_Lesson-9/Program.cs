using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            ComeBack:
            List<Student> list = new List<Student>();
            list.Add(new Student(1, "Abdulloh Halilov", "+998 99 815 32 14"));
            list.Add(new Student(2, "Abdumuxtorov Xojianvar", "+998 946 15 4212"));
            list.Add(new Student(3, "Axrorbek Yo'ldoshov", "+998 91 979 32 11"));
            list.Add(new Student(4, "Asadbek Murodaliyev", "+998 99 815 32 14"));
            list.Add(new Student(5, "Asatov Ergash", "+998 90 202 14 54"));
            list.Add(new Student(6, "Avazbek Muqimjonov", "+998 94 45 62"));
            list.Add(new Student(7, "Azamat G'iyosov", "+998 97 742 23 36"));
            list.Add(new Student(8, "Aziz Samadov", "+998 93 142 54 25"));
            list.Add(new Student(9, "Diyor Axmatov", "+998 99 815 32 14"));
            list.Add(new Student(10, "Humoyunmirzo", "+998 90 536 77 32"));
            list.Add(new Student(11, "Dilshodbek", "+998 93 533 12 75"));
            list.Add(new Student(12, "Nurbek", "+998 99 526 46 64"));
            list.Add(new Student(13, "Quvonshbek", "+998 90 035 69 28"));
            list.Add(new Student(14, "Sharafiddin", "+998 91 844 45 19"));
            list.Add(new Student(15, "Muhammadali", "+998 94 933 24 35"));
            list.Add(new Student(16, "Temurbek", "+998 91 319 85 26"));
            list.Add(new Student(17, "Tursunboy", "+998 94 114 56 75"));
            list.Add(new Student(18, "Chingizbek", "+998 93 375 25 52"));
            list.Add(new Student(19, "Xusan", "+998 90 827 11 85"));
            list.Add(new Student(20, "Zarina", "+998 99 452 12 24"));
            list.Add(new Student(21, "Xojiakbar", "+998 94 555 44 33"));
            list.Add(new Student(22, "Zikrillo", "+998 91 156 24 65"));
            list.Add(new Student(23, "Mahmudjon", "+998 97 295 47 32"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter ID : ");
            string input = Console.ReadLine();
            bool checkId = int.TryParse(input, out int id);
            if (!checkId)
            {
                Console.WriteLine("Iltimos faqat raqam kiriting");
                goto ComeBack;
            }
            else if (!(id >= 1 && id <= 23))
            {
                Console.WriteLine("ERROR");
                goto ComeBack;
            }
            Console.Clear();
            sw.Start();
            foreach (Student student in list)
            {
                if (student.Id == id)
                {
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.WriteLine($"Student Id : {student.Id}  Name : {student.Name}  Mobile Phone : {student.MobilePhone}");
                }
            }
            sw.Stop();
            Console.WriteLine("Time : " + sw.Elapsed);
            Console.ReadLine();
        }      
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string MobilePhone { get; set; }
            public Student(int id, string name, string mobilePhone)
            {
                Id = id;
                Name = name;
                MobilePhone = mobilePhone;
            }
        }
    }
}
