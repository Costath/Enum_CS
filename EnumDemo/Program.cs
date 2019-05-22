using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    [Flags]
    enum Genre { None = 0, Comedy = 1, Action = 2, Documentary = 4, Sci_Fi = 8, Romance = 16, Adult = 32}
    class Program
    {
        static void Main(string[] args)
        {
            //GenreDemo();

            //create the objects
            Time a = new Time(9, 35);
            Console.WriteLine(a);

            Time b = new Time(18, 5);
            Console.WriteLine(b);

            Time c = new Time(28, 500);
            Console.WriteLine(c);

            Time d = new Time(10);
            Console.WriteLine(d);

            // create a list to store the objects
            List<Time> times = new List<Time>() { a, b, c, d };

            //display all the objects
            Console.WriteLine("\n\nNormal time format");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            Console.WriteLine("\n\nMilitary time format");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetTimeFormat(TimeFormat.Mil);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }

            //change the format of the output
            Console.WriteLine("\n\n24 hour time format");
            Time.SetTimeFormat(TimeFormat.Hour24);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }




        }
        static void GenreDemo()
        {
            Genre genre = Genre.None;
            Console.WriteLine($"-> {genre}");
            if (genre == Genre.Action)
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("NOT ACTION");

            genre = Genre.Comedy | Genre.Romance | Genre.Action;      //combining multiple genres (bitwise OR operator)
            Console.WriteLine($"-> {genre}");

            if (genre.HasFlag(Genre.Action))
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("NOT ACTION");
        }
        static void DayDemo()
        {
            Day today = Day.Wed;
            Console.WriteLine($"Today: {today}");

            today += 1;
            Console.WriteLine($"Today: {today}");

            today += 1;
            Console.WriteLine($"Today: {today}");

            Console.WriteLine("Enter a day: ");
            string input = Console.ReadLine();

            today = (Day)Enum.Parse(typeof(Day), input);
            Console.WriteLine($"Today: {today}");
        }
    }
}
