using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Модуль 13.Основные коллекции С#
            /*
            13.1. Определение и виды коллекций

            **************************
            List
            **************************
            
            Простейший список однотипных объектов предоставляет класс List<T>. По функциональности это полный аналог ArrayList.

            Но при инициализации здесь нужно будет указывать тип объектов, которые мы собираемся хранить: 
                var strings = new List<string>(); //  в квадратных скобках укажем тип данных

            При этом не забудьте подключить соответствующий неймспейс: 
                using System.Collections.Generic;

            Класс List<T> представляет собой динамический массив объектов, а значит, он автоматически изменяет свой объём при добавлении и удалении новых.  Для этого он предоставляет методы Add() и Remove() соответственно.

            List<T> позволяет хранить дубликаты элементов.

            Таким образом, наша задача с телефонной книгой легко решается: см. внизу


            */
        }
    }
}

//ArrayList — это коллекция, которая представляет собой динамический массив. Он позволяет хранить элементы любого типа,
//автоматически увеличивая свой размер при добавлении новых элементов.
//Основные особенности:
//  Динамический размер – не нужно заранее указывать размер, как в обычном массиве (int[]).
//  Гетерогенность – может хранить элементы разных типов (числа, строки, объекты и т. д.).
//Проблемы:
//  Отсутствие типобезопасности – поскольку ArrayList хранит object, возможны ошибки при приведении типов.
//  Медленнее, чем List<T> – из-за упаковки (boxing) значимых типов (например, int в object).

//ArrayList — это устаревшая, но гибкая коллекция. В новых проектах лучше использовать List<T>, так как он обеспечивает типобезопасность и лучшую производительность.

//// Создание ArrayList
//ArrayList list = new ArrayList();

//// Добавление элементов разных типов
//list.Add(10);         // int
//list.Add("Hello");    // string
//list.Add(3.14);       // double
//list.Add(true);       // bool

//// Вывод элементов
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//// Удаление элемента
//list.Remove("Hello");

//// Доступ по индексу
//Console.WriteLine(list[0]); // 10

//// Количество элементов
//Console.WriteLine(list.Count); // 3


//Пример с List
//List<int> numbers = new List<int>(); // Только int
//numbers.Add(10);
//numbers.Add(20);
//// numbers.Add("Hello"); // Ошибка компиляции!


//задача с телефонной книгой
//using System;
//using System.Collections.Generic; // подключаем пространство имён с обобщёнными коллекциями

//namespace PhoneBook
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //  создаём пустой список с типом данных Contact
//            var phoneBook = new List<Contact>();

//            // добавляем контакты
//            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
//            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

//            // проверяем, что добавилось в список
//            foreach (var contact in phoneBook)
//                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
//        }
//    }

//    public class Contact // модель класса
//    {
//        public Contact(string name, long phoneNumber, String email) // метод-конструктор
//        {
//            Name = name;
//            PhoneNumber = phoneNumber;
//            Email = email;
//        }

//        public String Name { get; }
//        public long PhoneNumber { get; }
//        public String Email { get; }
//    }
//}

