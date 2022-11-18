namespace Stack
{
    public class StackBase
    {
        public static void Main(string[] args)

        {
            Stack stack = new Stack(4);
            stack.StackPrint();
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(90);
            stack.Push(23);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.StackPrint();
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.StackPrint();
            stack.GetTop();
        }
    }
}