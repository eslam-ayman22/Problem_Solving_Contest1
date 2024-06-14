namespace H._Data_Type_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            long n = long.Parse(ints[0]);
            long k = long.Parse(ints[1]);
            long a = long.Parse(ints[2]);

            if((n*k)%a != 0)
                Console.WriteLine("double");
            else if (n*k/a >= -2147483648 && n * k / a <= 2147483647)
                Console.WriteLine("int");
            else 
                Console.WriteLine("long long");
        }
    }
}
