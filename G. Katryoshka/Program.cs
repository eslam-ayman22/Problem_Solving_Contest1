namespace G._Katryoshka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split();
            long eyes = long.Parse(ints[0]);
            long mouth = long.Parse(ints[1]);
            long body = long.Parse(ints[2]);
            long result = 0;

            if (eyes == 0 && body == 0)
            {
                Console.WriteLine("0");
            }
            else { 
                if ((mouth >= eyes && mouth >= eyes) || (mouth >= eyes && mouth < body) || (mouth >= body && mouth < eyes))
                {
                    result = Math.Min(eyes, body);
                    Console.WriteLine(result);
                }
                else if (mouth < eyes && mouth < body)
                {
                    result = mouth;
                    eyes -= mouth;
                    body -= mouth;
                    result += Math.Min(eyes / 2, body);
                    Console.WriteLine(result);
                }


            }

        }
    }
}
