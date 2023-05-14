namespace _3_2_Inheritance2
{
    internal class Program
    {
        static void Main()
        {
            Adder a = new Adder();
            Console.WriteLine("Enter first integer:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int second = Convert.ToInt32(Console.ReadLine());

            int sum = a.Add(first, second);
            Console.WriteLine($"My Supper Class is: {a.GetType().BaseType.Name}");
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}