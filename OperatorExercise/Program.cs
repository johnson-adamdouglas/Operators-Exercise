namespace OperatorExercise
{
    internal class Program
    {
        public static double Area(double circleRadius)
        {
            return Math.PI * Math.Pow(circleRadius, 2);
            
        }
        static void Main(string[] args)
        {
            var x = 3;
            var y = 4;
            var z = ++x * y++;
            Console.WriteLine(z);

            int a = 17;
            int b = 4;
            int quotient = (a / b);
            int remainder = (a % b);
            double circleRadius;

            Console.WriteLine($"{a}+{b} is {a + b}");
            Console.WriteLine($"{a}-{b} is {a - b}");
            Console.WriteLine($"{a}*{b} is {a * b}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            circleRadius = double.Parse(Console.ReadLine());

            //double area = Math.PI * Math.Pow(radius, 2);
            double circleArea = Area(circleRadius);
            Console.WriteLine($"The area of a circle with radius of {circleRadius} is {circleArea}.");
        }
    }
}