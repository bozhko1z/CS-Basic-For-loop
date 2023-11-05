namespace ElementEqualToTheSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)

                    max = num;
                sum = sum + num;
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("yes, sum is: " + sum);
            }
            else
            {
                var diff = Math.Abs(max - sum);
                Console.WriteLine("no, diff: " + diff);
            }
        }
    }
}