using System;

namespace SinglyLinkedListExample
{
   
   class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)//constructor
            {
                Data = data;
                Next = null;
            }
        }

        class LinkedList
        {
            private Node head;

            public LinkedList()
            {
                head = null;
            }

            public void AddNode(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public void DisplayList()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                LinkedList myList = new LinkedList();

                // Add nodes to the linked list
                myList.AddNode(1);
                myList.AddNode(2);
                myList.AddNode(3);
                myList.AddNode(4);

                // Display the linked list
                Console.WriteLine("Linked List:");
                myList.DisplayList();
            }
        }

    }


