using System.Diagnostics;
using System.Xml.Linq;

namespace Topic_4_Asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            Double money;

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

            //Console.WriteLine("First name:");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Last name:");
            //lastName = Console.ReadLine();
            //Console.WriteLine("login:");
            //login= Console.ReadLine();
            //Console.WriteLine("Grade:");
            //int.TryParse(Console.ReadLine(), out grade);
            //Console.WriteLine("ID number:");
            //int.TryParse(Console.ReadLine(), out idNumber);
            //Console.WriteLine("Average:");
            //Double.TryParse(Console.ReadLine(), out average);
            //Console.WriteLine("Your information:");

            //Console.WriteLine("\tLogin:\t" +     login);
            //Console.WriteLine("\tID number:\t" + idNumber);
            //Console.WriteLine("\tName:\t" +      firstName + lastName);
            //Console.WriteLine("\tAverage:\t" +   average);
            //Console.WriteLine("\tGrade:\t" +     grade);



            //Console.WriteLine("Hello. What is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine("Hi " + name + ("!") + ("How old are you?"));
            //int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("Did you know that in five years you will be " + (age + 5 ) + " years old? And five years ago you were "
            //+ (age - 5) + ("!") + "Imagine that!");


            string item1, item2;
            double price1, price2, subTotal, discount, discountedPrice, tax, total;

            Console.WriteLine("What is the first item you baught?");
            item1 = Console.ReadLine();
            Console.WriteLine("What is the price of the first item?");
            Double.TryParse(Console.ReadLine(), out price1);

            Console.WriteLine("What is the second item you baught?");
            item2 = Console.ReadLine();
            Console.WriteLine("What is the price of the second item?");
            Double.TryParse(Console.ReadLine(), out price2);
            subTotal = price1 + price2;
            discount = subTotal * 0.2;
            discountedPrice = subTotal - discount;
            tax = discountedPrice * 0.13;
            total= discountedPrice + tax;

            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine(item1);
            Console.WriteLine(price1);
            Console.WriteLine(item2);
            Console.WriteLine(price2);
            Console.WriteLine("===============");
            Console.WriteLine(subTotal);
            Console.WriteLine(discount);
            Console.WriteLine(discountedPrice);
            Console.WriteLine(tax);
            Console.WriteLine("================");
            Console.WriteLine(total);






        }
    }
}
