namespace _5_3_findSqrtBinarySearch
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number whose sqrt you wants to find:");
            int n = Convert.ToInt32(Console.ReadLine());
            int l = 0, r = n, mid = (l + r) / 2;
            squareRoot sqrt = new squareRoot();
            int result = sqrt.findSqrt(n,l,r,mid);
            Console.WriteLine($"\nSquare root of {n} without decimals is : {result}");
        }
    }
}
