namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
        }
    }
}