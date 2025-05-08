using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Coleção Descrição Alguns métodos comuns
            //List<T> Lista indexada de objetos Add(), Insert(), Remove(), Sort()
            //Stack<T> Pilha, last-in first-out (LIFO) Push(), Pop(), Peek()
            //Queue<T> Fila, first-in first-out (FIFO) Enqueue(), Dequeue(), Peek()
            //HashSet<T> Conjunto de objetos diferentes Add(), Contains(), IntersectWith(), UnionWith()
            //Dictionary<K,V> Tabela de objetos indexados por chaves diferentes ContainsKey(), ContainsValue(), Add(), Remove()
            
            List<int>list = new List<int>();
            Stack<int>stack = new Stack<int>();
            Queue<int>queue = new Queue<int>();
            HashSet<int>hashset = new HashSet<int>();


            int[] inputs = new int[] {1, 10, -30, 10, -5};

            foreach(int number in inputs)
            {
                list.Add(number);
                stack.Push(number);
                queue.Enqueue(number);
                hashset.Add(number);
            }


            Console.WriteLine("List: " + String.Join(", ", list));

            Console.WriteLine("Stack : " + String.Join(", ", stack));

            Console.WriteLine("Queue : " + String.Join(", ", queue));
            
            Console.WriteLine("Hashset : " + String.Join(", ", hashset));
        }
        
    }
}