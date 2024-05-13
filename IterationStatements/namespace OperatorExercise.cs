namespace OperatorExercise
{


    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17
            ; int b = 4;
            var sum = a + b;

            var diff = a - b;

            var product = a * b;

            int quotient = a / b;

            int remainder = a % b;



            Console.WriteLine($"17+4 is {sum}, 17-4 is {diff}, 17*4 is {product}, 17/4 is {quotient} with a remainder of {remainder}");

            //AreaOfCircle




            Console.WriteLine($"What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            Console.WriteLine($"Since the radius of your circle is {radius}, this means the area of your circle is {area}.");

        }


    }


}