namespace D._Ali_Baba_and_Puzzles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            long a = long.Parse(ints[0]);
            long b = long.Parse(ints[1]);
            long c = long.Parse(ints[2]);
            long  d = long.Parse(ints[3]);

            if (a + b - c == d || a + b * c == d)
                Console.WriteLine("YES");
            else if(a - b + c == d || a - b * c==d)
                Console.WriteLine("YES");
            else if (a * b + c == d || a * b - c == d)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
