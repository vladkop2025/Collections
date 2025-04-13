﻿using System;
using System.Collections.Generic;

namespace LinkedListTest
{
    class Program
    {
        // объявим список в виде статической переменной
        public static LinkedList<string> LinkedList = new LinkedList<string>();

        static void Main()
        {
            // Добавим несколько элементов
            LinkedList.AddFirst("Лиса");
            LinkedList.AddFirst("Волк");
            LinkedList.AddFirst("Заяц");
            var mouse = LinkedList.AddFirst("Мышь");

            GoOnwards(); //   Прямой проход списка
            GoBackwards(); // Обратный проход списка

            // Вставка нового элемента
            LinkedList.AddAfter(mouse, "Медведь");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выведем список ещё раз после вставки");
            Console.WriteLine();


            GoOnwards(); //   Прямой проход списка
            GoBackwards(); // Обратный проход списка
        }

        static void GoOnwards()
        {
            LinkedListNode<string> node;

            Console.WriteLine("Элементы коллекции в прямом направлении: ");
            for (node = LinkedList.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");
        }

        static void GoBackwards()
        {
            LinkedListNode<string> node;

            Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
            for (node = LinkedList.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");
        }
    }
}