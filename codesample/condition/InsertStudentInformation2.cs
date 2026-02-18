using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesample.condition
{
    internal class InsertStudentInformation2
    {
        public static void InsertStudentInformation2Run()
        {
            Console.WriteLine("Let's fill out student grade:");

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            if (grade >= 90)
            {
                Console.WriteLine("Excellent! You are an A student!");

            }
            else if (grade >= 80)
            {
                Console.WriteLine("Good! You are above average!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Meh... You are doing alright...");
            }
            else if (grade >= 50)
                Console.WriteLine("Are you even trying? You can do better than that!"); // Don't Do This!! Always user { }

            else
            {
                Console.WriteLine("You have no talent... Maybe you should do something else?");
            }
        }
    }
}
