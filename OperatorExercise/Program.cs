namespace OperatorExercise
{
    internal class Program
    {
        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
            
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = (a / b);
            int remainder = (a % b);
            double radius;

            Console.WriteLine($"{a}+{b} is {a + b}");
            Console.WriteLine($"{a}-{b} is {a - b}");
            Console.WriteLine($"{a}*{b} is {a * b}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());

            //double area = Math.PI * Math.Pow(radius, 2);
            double area = Area(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}.");
        }
    }
}