
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




        public void StackPrint()
        {
        }
    }


}
