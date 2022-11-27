using System;

namespace CircularQueue
{
    public class CircularQueue
    {
        private int _size;
        private int[] _data;
        private int _start;
        private int _length;

        public CircularQueue(int size)
        {
            if(size > 0)
            {
                _size = size;
                _data = new int[_size];
                _start = 0;
                _length = 0;

            }
            else
                Console.WriteLine("The size must be grater tha zero");
            
        }

        public int getData(int index)
        {
            if (index > _start || index < (_length%_size))
                return _data[index];
            else
                throw new IndexOutOfRangeException("You must put an index that it is inside the range");
        }


        public int getStart()
        {
            return _start;
        }

        public int getLength()
        {
            return _length;
        }

        public void QueuePrintCircularQueue()
        {
            Console.WriteLine("---------- size = " + _length + ", start = " + _start + ", last = " + ((_start + _length - 1) % _size) + " ---------");
            for (int i = 0; i < _size; i++)
                Console.Write(_data[i] + " ");
            Console.WriteLine("size---------------------------------------------------size");
        }

        public void QueuePrintSimpleQueue()
        {
            Console.WriteLine("---------- size = " + _length + ", start = " + _start + ", last = " + ((_start + _length - 1) % _size) + " ----------");
            for (int i = 0; i < _length; i++)
                Console.Write(_data[(_start + i) % _size] + " ");
            Console.WriteLine("size---------------------------------------------------size");
        }

        public int Dequeue()
        {
            int dequeueOut = -1;
            if (IsFuctional() && !IsEmpty())
            {
            dequeueOut  = _data[_start];
                _data[_start] = 0;
                _length--;
                if (_length == 0)
                    _start = 0;
                else
                    _start = (_start + 1) % _size;
            }
            else
                Console.WriteLine("Queue is empty!!!");
            return dequeueOut;
        }

        public void Enqueue(int input)
        {
            if (IsFuctional() && !IsFull())
            {
                _data[(_start + _length) % _size] = input;
                _length++;
            }
            else
                Console.WriteLine("Queue is full or non functional!!!");
        }


        public int FindMax()
        {

            int max = -1;
            if (!IsEmpty())
            {
                max = _data[_start];
                for (int i = 1; i < _length; i++)
                    if (_data[(_start + i) % _size] > max)
                        max = _data[(_start + i) % _size];
            }
            else
                Console.WriteLine("Queue is empty!!!");
            return max;
        }

        public int FindMin()
        {

            int min = -1;
            if (!isEmpty())
            {
                min = _data[_start];
                for (int i = 1; i < _length; i++)
                    if (_data[(_start + i) % _size] < min)
                        min = _data[(_start + i) % _size];
            }
            else
                Console.WriteLine("Queue is empty!!!");
            return min;
        }

        public int FindSum()
        {

            int sum = -1;
            if (!isEmpty())
            {
                sum = 0;
                for (int i = 0; i < _length; i++)
                    sum += _data[(_start + i) % _size];
            }
            else
                Console.WriteLine("Queue is empty!!!");
            return sum;
        }

        public float FindAvg()
        {

            float avg = -1;
            if (!isEmpty())
                avg = this.FindSum() / (float)_data;
            else
                Console.WriteLine("Queue is empty!!!");
            return avg;
        }

        public bool IsEmpty()
        {
            return _length == 0;
        }

        public bool IsFull()
        {
            return _length == _size;
        }

        public bool IsFuctional()
        {
            return (_length >= 0 && _length <= _size);
        }
    }
}