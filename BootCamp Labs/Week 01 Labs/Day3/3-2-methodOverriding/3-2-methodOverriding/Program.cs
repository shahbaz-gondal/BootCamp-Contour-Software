namespace _3_2_methodOverriding
{
    internal class Program
    {
       static void Main()
        {
            Sports sp = new Sports();
            Soccer sc = new Soccer();
            Console.WriteLine(sp.getName());
            sp.getNumberOfTeamMembers();
            Console.WriteLine(sc.getName());
            sc.getNumberOfTeamMembers();
        }
    }
}