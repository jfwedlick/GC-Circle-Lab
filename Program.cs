namespace Circle_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunProgram();
            }
            catch
            {
                Exception ex = new Exception();
            }
            finally
            {
                Console.WriteLine($"Now ending the program..."); // I don't really need this... but I like it.
            }
        }

        static void RunProgram()
        {
            double radius = MakeCircle();
            CalculateCircle(radius);
        }
        
        static double MakeCircle()
        {
            while (true)
            {
                Console.Write("Hello! Please enter the radius of a circle: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                if (double.TryParse(userInput, out double radius))
                {
                    return radius;
                }
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        static void CalculateCircle(double radius)
        {
            Circle circle = new Circle(radius);
            radius = circle.GetRadius(radius);

            circle.CalculateDiameter(radius);
            circle.CalculateArea(radius);
            circle.CalculateCircumference(radius);

            while (true)
            {
                Console.WriteLine();
                Console.Write("Should the circle grow? Y/N: ");
                string userInput = Console.ReadLine().Trim().ToUpper();

                if (userInput == "Y")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Behold! The circle has grown:");
                    Console.WriteLine();
                    circle.Grow();
                    radius *= 2;
                    continue;
                }
                if (userInput == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Goodbye! The circle's final radius is {radius}.");
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}