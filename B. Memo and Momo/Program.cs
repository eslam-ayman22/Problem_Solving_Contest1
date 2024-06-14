namespace Memo_and_Momo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            long a = long.Parse(ints[0]);
            long b = long.Parse(ints[1]);
            long k = long.Parse(ints[2]);

            if(a%k==0 && b%k==0)
                Console.WriteLine("Both");
            else if(a%k==0 && b%k != 0)
                Console.WriteLine("Memo");
            else if(a%k !=0 && b%k==0)
                Console.WriteLine("Momo");
            else
                Console.WriteLine("No One");

        }
    }
}
