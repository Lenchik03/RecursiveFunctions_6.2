namespace З.А_задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int.TryParse(Console.ReadLine(), out int num);
            //int result = CountNumber(num);
            //Console.WriteLine(result);

            int[] array = new int[]{1,6,10,12,1,18,2};
            int result = Min(array, 3);
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
        //задача 5
        
        static int Min(int[] x, int k)
        {
            if(x.Length-1 == k)
            {
                return x[k];
            }
            int min = Min(x, k + 1);
            if (x[k] < min)
            {
                return x[k];
            }
            else 
                return min;
        }
        //задача 6
        //static int Sim(int S, int I, int J)
        //{

        //}
    }

}