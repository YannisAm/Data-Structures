namespace Queue
{
    public class Queue
    {
        private int front = -1;
        private int rear = 0;
        private int[]? queue;
        private int size;

        public Queue(int size)
        {
            if (size > 0)
            {
                this.size= size;
                queue = new int[size];
            }
        }

        public int GetFront()
        {
            try
            {
                if (front > -1 && front <= size - 1)
                    return front;
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("You can not get the front. An error occured");
                return -1;
            }
        }

        public int GetRear()
        {
            try
            {
                if (rear > -1 && rear <= size - 1)
                    return rear;
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("You can not get the front. An error occured");
                return -1;
            }
        }
    }
}