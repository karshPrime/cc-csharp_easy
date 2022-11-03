namespace DataTypesA
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.142;
            double radius = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Surface: " + (4 * pi * Math.Pow(radius, 2)));
            Console.WriteLine("Volume: " + (4 / 3 * pi * Math.Pow(radius, 3)));
        }
    }
}
