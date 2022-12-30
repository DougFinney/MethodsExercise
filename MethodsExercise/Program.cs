using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        public static void BeastBathSoap()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What's your favorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine($"What's your favorite animal, {userName}?");
            string faveAnimal = Console.ReadLine();

            Console.WriteLine($"What's your favorite scent, {userName}?");
            string faveScent = Console.ReadLine();

            string beastBathSoap = $"Thank you, {userName}." +
                $" we are shipping your order of {faveAnimal} shaped, {faveColor} colored and {faveScent} scented Beast Body Soap today!";
            Console.WriteLine(beastBathSoap);
        }


        static void Main(string[] args)
        {


            BeastBathSoap();

            Console.WriteLine(Add(4, 8));

            int answer = Subtract(9, 5);
            Console.WriteLine(answer);

            Console.WriteLine("Input first number");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input 2nd number");
            var y = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(x, y));

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}            
