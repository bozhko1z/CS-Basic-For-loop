namespace NumsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter nums: ");
            Console.WriteLine();
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}