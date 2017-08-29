using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaring an array
            //DataType [] nameOfArray = {Elements};
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            Console.WriteLine(students[4]);
            
            //10 vacation spots -  print first and last
            //3 kids-print out each child's age
            //GPA on a 4.0 scale of 8 students
            //first letter of peers names who are sitting next to you

            //vacation spots
            string[] vacationSpots = { "Miami", "OCMD", "Las Vegas", "Cancun", "London", "Paris", "Australia", "NY", "DC", "Hawaii" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[vacationSpots.Length-1]);

            string[] kidsAges = { "Ethan-13", "Hunter-11", "Micah-14" };
            foreach (string kid in kidsAges)
                {
                Console.WriteLine(kid);
                }


            /*float [] grades = { "4.0", "3.8", "3.2", "3.0", "2.8", "2.6", "2.4", "2.2" };
            foreach (string grade in grades)
            {
                Console.WriteLine(grade);
            }

            char[] peers = { 'G', 'J', 'H', };
            Console.WriteLine(peers);

            float[] gpa = new float[8];
            gpa[0] = 4.0f;
            gpa[1] = 3.5f;

            string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            Console.WriteLine(daysOfTheWeek );
            daysOfTheWeek.SetValue("Funday",0);

            int[] studentAges = new int[3];
            studentAges[0] = 15;
            studentAges[1] = 25;
            studentAges[2] = 28;
            */

            //string[] birthMonths = { "December", "July", "May", "July"};
            //Console.WriteLine(Array.IndexOf(birthMonths,"July"));
            //Console.WriteLine(Array.LastIndexOf(birthMonths, "July"));
            /*
            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length -1]);
            */

            string[] firstNames = { "Tom", "Bob", "Ted", "Ned" };
            Console.WriteLine(Array.IndexOf(firstNames, "Ted"));

            int[] luckyNumbers = { 1, 4, 8, 14, 15 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 4));

            char[] characters = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(characters[0]);
            characters.Reverse();
            Console.WriteLine(characters[0]);

            string[] students = { "Tom", "Bob", "Ted", "Ned" };
            Array.Sort(students);
            Console.WriteLine(students[0]);
            Console.WriteLine(students[students.Length-1]);

            int[] favNumbers = { 3, 5, 7, 154, 676, 33, 2, 67, 98, 436, };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);
            Console.WriteLine(favNumbers[favNumbers.Length-1]);














        }
    }
}
