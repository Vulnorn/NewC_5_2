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
            Random random = new Random();
            int minRandomNumber = 1;
            int maxRandomNumber = 10;

            shoppingQueue = CreateQueue(random, minRandomNumber, maxRandomNumber);
            WorkShop(shoppingQueue);
        }

        static Queue<int> CreateQueue(Random random, int minRandomNumber, int maxRandomNumber)
        {
            Queue<int> shoppingQueue = new Queue<int>();

            int purchaseAmount;
            int numberBuyers = random.Next(minRandomNumber, maxRandomNumber);

            for (int i = numberBuyers; i > 0; i--)
            {
                purchaseAmount = random.Next(minRandomNumber, maxRandomNumber);
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