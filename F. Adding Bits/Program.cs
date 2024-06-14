namespace F._Adding_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            int a = int.Parse(ints[0]);
            int b = int.Parse(ints[1]);
            int c = a ^ b;
            Console.WriteLine(c);
        }
    }
}
