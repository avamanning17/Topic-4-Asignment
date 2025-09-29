using System.Diagnostics;
using System.Xml.Linq;

namespace Topic_4_Asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String name;
            //int age;
            //Double money;

            //Console.WriteLine("Hello what is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Hello " + name + ("!") + " How old are you?");
            //int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine();
            //Console.WriteLine("So youre " + age + " eh? Thats not old at all! How much do you make, " + name + ("?"));
            //Double.TryParse(Console.ReadLine(), out money);
            //Console.WriteLine();
            //Console.WriteLine(money.ToString("C") + ("!") + " I hope that's per hour and not per year!");

            String firstName, lastName, login;
            int grade, idNumber;
            Double average;

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out grade);
            int.TryParse(Console.ReadLine(), out idNumber);
            Double.TryParse(Console.ReadLine(), out average);

        login: Console.WriteLine("ID: /t/t");





        }
    }
}
