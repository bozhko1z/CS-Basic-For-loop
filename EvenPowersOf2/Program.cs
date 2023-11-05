namespace EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (var i = 0; i <= n; i += 2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}