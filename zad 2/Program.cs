namespace zad_2
{
    internal class Program
    {
            static Stack<char> stack = new Stack<char>();
        static void Main(string[] args)
        {

           
        }
        static void Look()
        {
            int see = 0;
            foreach (char c in stack)
            {
                if (c == ')')
                    see++;
                else if (c == ']')
                    see =+ 2;
                else if (c == '}')
                    see = +3;
                else if (c == '{')
                    see = -3;
                else if (c == '[')
                    see = -2;
                else if (c == '(')
                    see--;
            }
        }
    }
}
