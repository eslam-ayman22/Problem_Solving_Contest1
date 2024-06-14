namespace C._Next_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char x = char.Parse(Console.ReadLine()) ;
            
            if (x == 'z')
            {
                Console.WriteLine("a");

            }
            else
            {
                Console.WriteLine(++x);
            }
        }
    }
}
