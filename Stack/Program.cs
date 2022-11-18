
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Stack
{
    public class Stack : StackBase
    {
        private int top = -1;       //here we initialize the top variable assigning it the value of -1
        private int[]? stack;       //we initialize the stack array, but we will assign it's size in the constructor to make it more dynamic
        private int size;           //here we initialize the size of the array but it's value we will be assigned with the constructor

        public Stack(int size)      //we initialize the size of our stack declaring it in the constuctor and checking if it is grater than zero because
        {                           //there is no stack with zero or negative size
            if (size > 0)
            {
                this.size = size;
                stack = new int[size];
            }
            else
                Console.WriteLine("You can not have a stask, with zero or negative size");
        }

        public int GetTop()                     //we initialize the getter for the variable top. if the top is in the limits of the size of the stack
        {                                       //then we return it else we send an exception
            try
            {
                if (top > -1 && top <= size-1)
                    return top;
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"You can not take the top value: {ex.Message}");
                return -1;
            }
            
            
        }

        public int GetSize()                
        {
            try                             //we initialize the getter for the size of the stack. if the size is greater than zero, that means that we
            {                               //have initialized it and we can return it, else an exception is thrown.
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

        private bool IsFunctional()                 //it's checked if the stack is within the limits
        {
            return (top >= -1 && top <= size-1);
        }

        private bool IsFull()                       //it's checks if the stack is full or not
        {
            return top == size - 1;
        }

        private bool IsEmpty()                      //it's checks if the stack is empty or not
        {
            return top == -1;
        }

        public void Push(int number)                //when the method Push is called then we put an element to the last position of our stack. To do so 
        {                                           //first we check if the stack is not full and is functional
            if (!IsFull() && IsFunctional())
            {
                stack[++top] = number;
                Console.WriteLine($"The {number} has been pushed");
            }
            else
                Console.WriteLine("The stack is full. If you want to push something you have to pop an element first");

        }

        public void Pop()                       //when the method Pop is called then the last element of the stack is beeing removed. Before doing this
        {                                       //we check if the stack is empty or not
            if (!IsEmpty())
            {
                int outNumber = stack[top];
                stack[top--] = 0;
                Console.WriteLine($"The {outNumber} has been poped out of the stack!");
            }
            else
                Console.WriteLine("You can not pop an element out of an empty stack.");

        }


        public void StackPrint()                    //calling this method we print the elements in the stack
        {
            try
            {
                if (top >= 0)
                {
                    Console.WriteLine("-------------- size = " + (top + 1) + " ----------");

                    for (int i = 0; i <= top; i++)
                        Console.Write(stack[i] + " ");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------");
                }
                else
                {
                    throw new Exception();        
                }                                                                                              }
            catch (Exception)
            {
                Console.WriteLine("You can not print an empty stack");
            }
        }
    }


}
