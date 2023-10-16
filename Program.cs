namespace З.А_задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int num);
            int result = CountNumber(num);
            Console.WriteLine(result);
        }
        //задача 2
        static int CountNumber(int n)
        {
            if (n <= 0)
                return 0;
            else
                return 1 + CountNumber(n / 10);
        }
        //задача 4
        static int Root(int a, int b, int c)
        {

        }
    }

}