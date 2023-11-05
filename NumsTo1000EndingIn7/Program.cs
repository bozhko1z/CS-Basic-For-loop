namespace NumsTo1000EndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 1000000000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}