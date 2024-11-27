using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> shoppingQueue;

            shoppingQueue = CreateQueue();
            WorkShop(shoppingQueue);
        }

        static Queue<int> CreateQueue()
        {
            Random random = new Random();

            Queue<int> shoppingQueue = new Queue<int>();

            int minRandomNumberBuyers = 1;
            int maxRandomNumberBuyers = 10;
            int minRandomPurchaseAmount = 1;
            int maxRandomPurchaseAmount = 10;           
            int numberBuyers = random.Next(minRandomNumberBuyers, maxRandomNumberBuyers + 1);

            for (int i = numberBuyers; i > 0; i--)
            {
               int purchaseAmount = random.Next(minRandomPurchaseAmount, maxRandomPurchaseAmount + 1);
                shoppingQueue.Enqueue(purchaseAmount);
            }

            return shoppingQueue;
        }

        static void WorkShop(Queue<int> shoppingQueue)
        {
            int accountTotal = 0;

            while (shoppingQueue.Count != 0)
            {
                Console.WriteLine($"Счет текущего клиента: {shoppingQueue.First()}.");
                accountTotal += shoppingQueue.Dequeue();
                Console.WriteLine($"Клиент совершил покупку. Счет магазина: {accountTotal}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Очередь закончилась, вы обслужили всех клиентов, Счет магазина: {accountTotal}");
            Console.ReadKey();
        }
    }
}