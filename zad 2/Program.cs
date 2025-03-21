namespace zad_2
{
    internal class Program
    {
        static Stack<char> stack = new Stack<char>();

        static void Main(string[] args)
        {
            stack.Push('{');
            stack.Push('[');
            stack.Push('(');
            stack.Push(')');
            stack.Push(']');
            stack.Push('}');

            Look();
        }

        static void Look()
        {
            Stack<char> right = new Stack<char>();
            int halfCount = stack.Count / 2;

            while (stack.Count > halfCount)
            {
                right.Push(stack.Pop());
            }

            Stack<char> left = new Stack<char>();
            while (stack.Count > 0)
            {
                left.Push(stack.Pop());
            }

            while (right.Count > 0)
            {
                char rightBracket = right.Pop();
                if (left.Count == 0)
                {
                    Console.WriteLine("Error");
                    return;
                }

                char leftBracket = left.Pop();

                if (!IsMatchingPair(leftBracket, rightBracket))
                {
                    Console.WriteLine("Error");
                    return;
                }
            }

            Console.WriteLine("Valid");
        }

        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
    }
}
