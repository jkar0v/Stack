namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число от интервала 5 до 55:");
            int n = int.Parse(Console.ReadLine());

            if (n < 5 || n > 55)
            {
                Console.WriteLine("Числото трябва да бъде между 5 и 55" +
                    "\nРестартирайте програмата за нов опит!");
                return;
            }

            Stack<int> fibonacciStack = new Stack<int>();
            int a = 1, b = 1;

            fibonacciStack.Push(a);
            fibonacciStack.Push(b);

            for (int i = 3; i <= n; i++)
            {
                int next = a + b;
                fibonacciStack.Push(next);
                a = b;
                b = next;
            }
            Console.WriteLine("Изход: " + string.Join("; ", fibonacciStack));
        }
    }
}
