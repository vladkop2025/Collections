﻿//массив — простейшую коллекцию для хранения  однотипных объектов
//Варианты объявления массива типа int (значение по умолчанию 0)
//Обращение по несуществующему индексу массива вызовет System.IndexOutOfRangeException
//int[] one = new int[4] { 1, 2, 3, 5 }
//int[] two = new int[] { 1, 2, 3, 5 };
//int[] three = new[] { 1, 2, 3, 5 };
//int[] four = { 1, 2, 3, 5 };
using System;
using System.IO;
namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("C:\\Users\\vladk\\Desktop\\cdev_Text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);
        }
    }
}


//Подсказка(1 из 1): Для разделения текста на слова вы наверняка будете использовать метод String.Split(...).
//В этом случае перегрузите его, передав дополнительный параметр StringSplitOptions.RemoveEmptyEntries (так вы избавитесь от пустых строк в выборке).

//Виды коллекций
//Выше мы с вами повторили массив — простейшую коллекцию для хранения  однотипных объектов.

//Но работать с массивами далеко не всегда удобно. Как мы помним, при инициализации мы должны сразу выделить память под массив определённой длины,
//то есть использование массива оптимально, когда мы знаем, сколько элементов будет нужно в него сохранить.

//Но в ваших программах часто будет встречаться ситуация, когда вы не знаете сколько будет элементов, либо когда вам требуется постоянно добавлять
//или удалять элементы из коллекции. Пример — телефонная книга, в которую записываются новые контакты.

//В этом и во многих других похожих случаях гораздо выгоднее использовать другие виды коллекций. Многие из них реализуют стандартные
//данных, например стек, словарь, очередь. 

//Все они будут полезны для решения специализированных задач и всех их мы с вами рассмотрим далее.

//Условно все коллекции делятся на обобщенные (содержатся в пространстве имён System.Collections.Generic) и необобщенные типизированные (System.Collections).

//Для решения задач параллельного и многопоточного доступа используют коллекции из пространства имён System.Collections.Concurrent.

//Простым языком: разница между необобщенными и обобщенными коллекциями стоит в том, что первые хранят данные разных типов, а вторые — одного.