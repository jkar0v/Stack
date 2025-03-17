namespace zad_1
{
    internal class Program
    {
            static Stack<char> stack = new Stack<char>();
        static void Main(string[] args)
        {
            stack.Push('H');
            stack.Push('a');
            stack.Push('l');
            stack.Push('l');
            stack.Push('o');

            PrintStack();
        }
        static void PrintStack()
        {
            foreach (char c in stack)
            {
                Console.Write(c);
            }
        }
    }
}
