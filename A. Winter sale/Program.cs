namespace Winter_sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            double percentage = int.Parse(ints[0]);
            double PriceAfterPercentage = int.Parse(ints[1]);

            double originalPrice = PriceAfterPercentage / (1 - percentage / 100);
            Console.WriteLine($"{originalPrice:f2}");
        }
    }
}
