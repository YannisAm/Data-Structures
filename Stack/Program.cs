
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Stack
{
    public class Stack : StackBase
    {
        private int top = -1;
        private int[]? stack;
        private int size;

        public Stack(int size)
        {
            if (size > 0)
                this.stack = new int[size];
            else
                Console.WriteLine("You can not have a stask, with zero or negative size");
        }

        public int GetTop()
        {
            try
            {
                if (size > 0)
                    return top;
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Stack overflow: {ex.Message}");
                return -1;
            }
            
            
        }

        public int GetSize()
        {
            try
            {
                if (size >= 0)
                    return size;
                else
                    throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine($"The stack is an undifined size : {e.Message}");
                return -1;
            }
        }

        private bool IsFunctional()
        {
            if (top > -1 && top <= size - 1)
                return true;
            else
                return false;
        }

        private bool IsFull()
        {
            if (top > size - 1)
                return true;
            else
                return false;
        }

        private bool IsEmpty()
        {
            if (top < size-1)
                return true;
            else
                return false;
        }

        public void Push(int number)
        {
            if(IsEmpty() && IsFunctional())
            {
                stack[++top] = number;
                Console.WriteLine($"The {number} has been pushed");
            }
            else
                Console.WriteLine("The stack is full. If you want to push something you have to pop an element first");

        }


        public void StackPrint()
        {
        }
    }


}
