namespace Queue
{
    public class Queue
    {
        private int front = 0;          //Here it is initialized the front, rear, size and the queue array. We assign the values of 0 and -1 to front
        private int rear = -1;          //and rear respectivelly.
        private int[]? queue;
        private int size;

        public Queue(int size)          //With the constructor we use the value to initialize the queue size. To do that we check if the size is greater
        {                               //than zero then it is assigned to the size of the queue
            if (size > 0)
            {
                this.size= size;
                queue = new int[size];
            }
        }

        public int GetFront()           //With this method we get the value of the front element of the queue
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

        public int GetRear()        //With this method we get the value of the rear element of the queue
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

        public void Push(int number)            //With this method we push a number to our queue. It is passed in the last position of the queue,
        {                                       //checking if is Empty or Functional
            if(IsEmpty() && IsFunctional())
            {
                queue[++rear] = number;
            }
        }

        public int Pop()                        //With this method we pop a number from our queue. We pop a number from the front of our queue
        {
            if(!IsEmpty() && IsFunctional())
            {
                int number  = queue[front];
                for(int i = 0; i <= size - 1; i++)
                    queue[i] = queue[i + 1];
                return number;
            }
            else
            {
                Console.WriteLine("You can not pop an element from an empty queue");
                return -1;
            }
        }

        public bool IsEmpty()               //We check if the queue is empty or not
        {
            if (rear == size-1)
                return false;
            else
                return true;
        }

        public bool IsFunctional()          //We check if we are inside the boundaries of our queue
        {
            if (front >= -1 && rear <= size - 1)
                return true;
            else
                return false;
        }
    }
}