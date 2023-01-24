namespace _3_2_Interface
{
    internal class Program
    {
       static void Main()
        {
            MyCalculator c = new MyCalculator();
            int sum = c.divisor_sum();
            Console.WriteLine($"I Implemented: {c.GetType().BaseType.Name}");
            Console.WriteLine($"sum is: {sum}");
        }
    }
}
