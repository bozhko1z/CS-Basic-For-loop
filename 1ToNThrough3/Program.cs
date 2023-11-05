namespace _1ToNThrough3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i += 3)
            {

                Console.WriteLine(i);
            }
        }
    }
}