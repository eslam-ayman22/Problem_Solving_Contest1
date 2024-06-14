namespace I._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = x / 10;
            int z = x % 10;
          
            if(y==0 || z == 0)
            {
                Console.WriteLine("YES");
            }
           else if (y >= z)
            {
                if (y % z == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else if (z > y)
            {
                if (z % y == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
