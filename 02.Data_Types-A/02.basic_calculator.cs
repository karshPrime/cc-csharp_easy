namespace DataTypesA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
        }
    }
}
