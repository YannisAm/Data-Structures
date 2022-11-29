# The journey to Data-Structures

##### This project is being created to improve one's understanding of data structures. For this reason, not only can I understand what their purpose is, but I will also code them in C#. Below follows a list of all the data structures that are currently finished.

1. Stack



### STACK

Stack is one of the most important of them. With this data structure, the new programmer begins to learn about data structures and how they can help him or her with programming.

Let's visualize what a stack is:

![This is a stack](https://holycoders.com/content/images/wordpress/2020/04/Stack-data-structure.png)

  As we can see in the picture, there is only one way to push or pop items in and out of the stack, respectively. The last element that enters the stack is the first element that exits it. This procedure is called LIFO (Last In, First Out). If we put three elements in the stack and we want to remove the bottom-down element, then we have to remove all the elements above it. For more information, please see the Stack project. 


### QUEUE

#### 1. Simple Queue

I am going to code two different kinds of queues. Let's start with the simple one.

  * The first element that enters is the first element that exits in the simple queue.This procedure is called FIFO.
(FIFO) (First in, First Out) When we add an element, we say "enqueue," and when we remove an element, we say "dequeue." So, when we extract the first element, then all the other elements must occupy the position in front of it. This procedure uses a lot of resources, especially if we have a queue with many elements. Later, we are going to see how to make the queue more efficient.

Let's visualize the simple queue:

![This is a simple queue](https://cdn.programiz.com/sites/tutorial2program/files/simple-queue_0.png)

#### 2. Circular Queue

  * The difference between this queue and the previous one is that in a circular queue, the element does not have to start at the beginning. We "bring" the beginning of the queue to where the element is. It is a little different, but it is way more efficient than the simple queue. 

Let's visualize the circular queue:

![This is a circular queue](https://static.javatpoint.com/ds/images/circular-queue.png)
