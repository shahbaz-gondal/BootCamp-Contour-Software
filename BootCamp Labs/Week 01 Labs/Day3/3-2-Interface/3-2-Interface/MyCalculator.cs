
namespace _3_2_Interface
{
     internal class MyCalculator: AdvancedArithmetic
    {
        public int divisor_sum()
        {
            int sum = 0, n = 0, m = 0;
            Console.WriteLine("Enter an integer:");
            m = Console.ReadLine();
            n = Convert.ToInt32(m);
            for (int i=1; i<=n; i++)
            {
                if(n%i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
