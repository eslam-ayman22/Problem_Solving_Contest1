namespace E._Interval_Sweep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            int x = int.Parse(ints[0]);
            int y = int.Parse(ints[1]);
            if(x==0 && y==0)
                Console.WriteLine("NO");
            else if(Math.Abs(x-y)==1 || Math.Abs(x-y)==0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
        }
    }
}
