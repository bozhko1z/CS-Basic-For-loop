namespace nTo1Reversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}