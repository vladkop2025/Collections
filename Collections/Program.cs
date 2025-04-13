using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListTest
{
    class Program
    {
        // объявим список в виде статической переменной
        public static LinkedList<string> LinkedList = new LinkedList<string>();

        static void Main()
        {

            //// читаем весь файл с рабочего стола в строку текста
            //string text = File.ReadAllText("C:\\Users\\vladk\\Desktop\\cdev_Text.txt");

            ////убираем знаки пунктуации из текста
            //var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            //// Сохраняем символы-разделители в массив
            //char[] delimiters = new char[] { ' ', '\r', '\n' };

            //// разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            //var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
