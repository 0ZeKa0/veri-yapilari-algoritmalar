namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki işlemde yalnızca sonuç yazılır.
            Console.WriteLine(fakt(5));
            Console.WriteLine(fib(5));
            Console.WriteLine(sum(34));


        }

        static int fakt(int x)
        {

            if (x > 1)
            {
                return x * (x - 1);
            }
            else
            {
                return 1;
            }
        }

        static int fib(int x)
        {
            if (x >= 3)
            {
                return fib(x-1)+fib(x-2); 
            }
            else
            {
                return 1;
            }
        }
        static int sum(int x)
        {
            if(x > 1)
            {
                return x+ sum(x-1);
            }
            else
            {
                return 0;
            }
        }

        static int grid_paths(int x, int y)
        {
            if(x==1 || y == 1)
            {
                return 1;
            }
            else
            {
                return grid_paths(x, y - 1) + grid_paths(x - 1, y); 
            }

        }
    }
}