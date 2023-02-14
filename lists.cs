using System;
using System.Collections.Generic;

namespace another_one
{
    class Program
    {
        class LinkedListNode<T>
        {
            public T data;
            public LinkedListNode<T> next;

            //constractor:
            public LinkedListNode(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        class LinkedList<T>
        {
            public LinkedListNode<T> head;
            int count;
            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void addNodeToFirst(T data)
            {
                LinkedListNode<T> node = new LinkedListNode<T>(data);
                if(head == null)
                {
                    head.next = node;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
                count++;
                
            }


            public void addNodeToEnd(T data)
            {
                LinkedListNode<T> temp = this.head;
                LinkedListNode<T> lastnode = new LinkedListNode<T>(data);
                if(head == null)
                {
                    head.next = lastnode;
                }
                else
                {
                    while(temp.next != null)
                    {
                        temp = temp.next;
                    }
                
                temp.next = lastnode;
                lastnode.next = null;
                }
                count++;

                
            }

            public void addItemByIndex(T data, int index)
            {
                LinkedListNode<T> midItem = new LinkedListNode<T>(data);
                LinkedListNode<T> temp = this.head;
                if(index == 0 || head == null)
                {
                    addNodeToFirst(data);
                }
                else
                {
                    int counter = 0;
                    while(counter != index - 1 && temp != null)
                    {
                        counter++;
                        temp = temp.next;
                    }
                    midItem.next = temp.next;
                    temp.next = midItem;
                    count++;
                }
            }

            // public void addNodeToMidle(LinkedListNode<T> midleNode, T data)
            // {
            //     LinkedListNode<T> temp = head;
            //     while(temp.next != midleNode)
            //     {
            //         temp = temp.next;
            //     }
            //     LinkedListNode<T> NewMidleNode = new LinkedListNode<T>(data);
            //     NewMidleNode.next = temp.next;
            //     temp.next = NewMidleNode;
            // }
            public void removeFirstNode()
            {
                head = head.next;
                count--;
            }
             
            public void removeLastNode()
            {
                LinkedListNode<T> temp = this.head;
                if(head == null)
                {
                    temp.next = null;
                }
                else
                {
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                }
                count--;
                
            }
        }
    }
}