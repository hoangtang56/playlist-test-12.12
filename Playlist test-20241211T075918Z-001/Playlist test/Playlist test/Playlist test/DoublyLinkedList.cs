using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_test
{
    public class Node2
    {
        public object element;
        public Node2 flink, blink;
        public Node2()
        {
            element = null;
            flink = blink = null;
        }
        public Node2(object element)
        {
            this.element = element;
            flink = blink = null;
        }
    }
    public class DoublyLinkedList
    {
        public Node2 header;

        public DoublyLinkedList()
        {
            header = new Node2("Header");
        }

        public Node2 GetFirst()
        {
            return header.flink;
        }
        public Node2 FindPrev(object ele)
        {
            Node2 current = header;
            while (current.flink.element != ele)
                current = current.flink;
            return current;
        }
        public void Swap(object eleA, object eleB)
        {
            Node2 prevA = FindPrev(eleA);
            Node2 prevB = FindPrev(eleB);
            Remove(eleB);
            Insert(eleA, prevB.element);
            Insert(eleB, prevA.element);
            Remove(eleA);
        }
        private Node2 Find(object element)
        {
            Node2 current = header;
            while (current != null && current.element != element)
            {
                current = current.flink;
            }
            return current;
        }

        public void Insert(object newElement, object afterElement)
        {
            Node2 current = Find(afterElement);
            if (current == null) return;

            Node2 newNode = new Node2(newElement);
            newNode.flink = current.flink;
            newNode.blink = current;
            current.flink = newNode;
            if (newNode.flink != null)
            {
                newNode.flink.blink = newNode;
            }
        }

        public void Remove(object element)
        {
            Node2 current = Find(element);
            if (current == null || current == header)
                return;
            if (current.flink != null)
            {
                current.flink.blink = current.blink;
            }
            if (current.blink != null)
            {
                current.blink.flink = current.flink;
            }
        }
        public void Clear()
        {
            Node2 current = GetFirst();
            while (current != null)
            {
                if (current.flink != null)
                    current.flink.blink = null; // Xóa blink của next
                current.flink = null;
                current.blink = null;
                current = current.flink;
            }
            header.flink = null;
        }
        public void Shuffle()
        {
            List<Node2> nodes = new List<Node2>();
            Node2 current = GetFirst();
            while (current != null)
            {
                nodes.Add(current);
                current = current.flink;
            }

            // Shuffle the list using Fisher-Yates algorithm
            Random random = new Random();
            for (int i = nodes.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (nodes[i], nodes[j]) = (nodes[j], nodes[i]);
            }

            // Rebuild the linked list with the shuffled nodes
            if (nodes.Count > 0)
            {
                // Update the header's `flink` to point to the first node in the shuffled list
                header.flink = nodes[0];
                nodes[0].blink = header;

                // Link shuffled nodes together
                for (int i = 0; i < nodes.Count - 1; i++)
                {
                    nodes[i].flink = nodes[i + 1];
                    nodes[i + 1].blink = nodes[i];
                }

                // Terminate the last node
                nodes[nodes.Count - 1].flink = null;
            }
        }

        public void SortAsc()
        {
            if (header == null || header.flink == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node2 current = header.flink;

                while (current.flink != null)
                {
                    if (string.Compare(current.element.ToString(), current.flink.element.ToString(), StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap elements
                        Swap(current.element, current.flink.element);
                        swapped = true;
                    }
                    current = current.flink;
                }
            } while (swapped);
        }
        public void SortDesc()
        {
            if (header == null || header.flink == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node2 current = header.flink;

                while (current.flink != null)
                {
                    if (string.Compare(current.element.ToString(), current.flink.element.ToString(), StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        // Swap elements
                        Swap(current.element, current.flink.element);
                        swapped = true;
                    }
                    current = current.flink;
                }
            } while (swapped);
        }
        public Node2 GetAt(int index)
        {
            Node2 current = header.flink;
            int count = 0;
            while (current != null && count < index)
            {
                current = current.flink;
                count++;
            }
            return current;
        }

    
    }
}
