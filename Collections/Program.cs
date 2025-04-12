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
            13.2. Необобщенные коллекции

            //ArrayList — это коллекция, которая представляет собой динамический массив. Он позволяет хранить элементы любого типа,
            //автоматически увеличивая свой размер при добавлении новых элементов.
            //Основные особенности:
            //  Динамический размер – не нужно заранее указывать размер, как в обычном массиве (int[]).
            //  Гетерогенность – может хранить элементы разных типов (числа, строки, объекты и т. д.).
            //Проблемы:
            //  Отсутствие типобезопасности – поскольку ArrayList хранит object, возможны ошибки при приведении типов.
            //  Медленнее, чем List<T> – из-за упаковки (boxing) значимых типов (например, int в object).

            //ArrayList — это устаревшая, но гибкая коллекция. В новых проектах лучше использовать List<T>, так как он обеспечивает типобезопасность 
            и лучшую производительность.

            // Создание ArrayList
            ArrayList list = new ArrayList();

            // Добавление элементов разных типов
            list.Add(10);         // int
            list.Add("Hello");    // string
            list.Add(3.14);       // double
            list.Add(true);       // bool

            // Вывод элементов
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Удаление элемента
            list.Remove("Hello");

            // Доступ по индексу
            Console.WriteLine(list[0]); // 10

            // Количество элементов
            Console.WriteLine(list.Count); // 3

            13.3. Основные коллекции. Часть 1
            **************************
            ArrayList
            **************************
            Доступ к элементам ArrayList
            Класс  ArrayList, аналогично массиву Array, позволяет доступ к элементам по индексу.

            Поскольку мы заранее не знаем, какого типа каждый конкретный элемент в ArrayList, при доступе к нему мы каждый раз должны выполнять 
            приведение к конкретному типу, либо давать среде это сделать автоматически (используя ключевое слово var): см. ниже



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

            Пример с List
            List<int> numbers = new List<int>(); // Только int
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add("Hello"); // Ошибка компиляции!

            Таким образом, наша задача с телефонной книгой легко решается: см. внизу


            */
            var months = new List<string>()
            { 
              "Янв", "Фев", "Мар", "Апр", "Май", "Июн"
            };
            months.Add("Июл");                         //вставка элемента в конец списка
            months.AddRange(new[] { "Авг", "Сен" });   //вставка нескольких элементов в конец
            var slice = months.GetRange(4, 3);         //подсписок (срез) элементов из исходного списка c 4 и вернуть 3 элемента

            months.Sort();
            months.BinarySearch("Апр");                 //вернет индекс элемента поиска

            int index = months.IndexOf("Апр");          //вернет индекс элемент 

            months.Insert(1, "Test");                   //вставка элемента в индекс 1
            var removeresult = months.Remove("Авг");    //если нашел, удаляет, иначе результат False
            months.RemoveAt(0);                         //удаляет 1 элемент массива
            months.Remove("Янв");                       //если нашел, удаляет, иначе результат False
            months.RemoveRange(3, 5);                   //Удаляет из списка 5 элементов, начиная с индекса 3.

            months.Reverse();                           //Переворачивает список
            months.Count();                             //кол-во элементов списка
            months.Clear();                             //Очищает список
            months.Contains("Feb");                     //Проверяет, содержится ли в списке искомый объект
                                                        //months.CopyTo(Array array)                - Копирует текущий список в массив array
                                                        //ArrayList GetRange(int index, int count)  - Возвращает новый ArrayList заданной длины, начиная с текущей позиции. Иначе говоря, «вырезает» из массива кусок в нужном месте.

            // выведем результат
            foreach (var o in months)
                Console.WriteLine(o);

        }

    }
}

//// инициализация ArrayList
//var combinedList = new ArrayList();

////  пробегаемся по массиву чисел
//foreach (var number in numbers)
//{
//    // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
//    combinedList.Add(months[number - 1]);

//    // добавляем его порядковый номер
//    combinedList.Add(number);
//}

//foreach (var value in combinedList)
//    Console.WriteLine(value);

//Напишите метод, который на вход принимает любой Arraylist input, а на выходе выдает другой Arraylist с двумя элементами,
//где первый — число (сумма целочисленных элементов input), а второй — строка (текст, составленный из строковых элементов input).

//Посмотреть ответ для самопроверки
//using System;
//using System.Collections;
//using System.Text;
 
//namespace ArrayListExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Объявим ArrayList с элементами разных типов
//            var arrayList = new ArrayList()
//           {
//               1,
//               "Андрей ",
//               "Сергей ",
//               300,
//           };

//            // переменная для хранения суммы
//            int sum = 0;

//            // переменная для хранения текста.
//            // Можно было бы использовать String, но в случае когда необходимо выполнять много
//            // операций с одной строкой - лучше использовать класс StringBuilder
//            StringBuilder text = new StringBuilder();

//            // проходим список и проверяем элементы на соответствие типу
//            foreach (var element in arrayList)
//            {
//                //   если целое число - увеличиваем счётчик
//                if (element is int)
//                {
//                    sum += (int)element;
//                }

//                // если строка - добавляем текст из неё
//                if (element is string s)
//                {
//                    text.Append(element);
//                }
//            }

//            // результат
//            var result = new ArrayList() { sum, text.ToString() };

//            // вывод
//            foreach (var elem in result)
//            {
//                Console.WriteLine(elem);
//            }
//        }
//    }
//}



//Доступ к элементам ArrayList
//using System;
//using System.Collections;

//namespace ArrayListExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Объявим ArrayList с элементами разных типов
//            var arlist = new ArrayList()
//           {
//               1,
//               "Андрей",
//               300,
//               4.5f
//           };

//            // Получим первый элемент по индексу
//            int firstElement = (int)arlist[0];
//            Console.WriteLine(firstElement);

//            string secondElement = (string)arlist[1];
//            Console.WriteLine(secondElement);
//            /* int secondElement = (int) arlist[1]; Ошибка (пытаемся привести строку к числу) */

//            // используем ключевое слово var, чтобы не приводить к типу
//            var firstElementVar = arlist[0]; // получим запакованный объект
//            var secondElementVar = arlist[1];
//            /* var fifthElement = arlist[5]; Error: Index out of range (обращение по несуществующему индексу) */

//            // Обновление элементов по индексу
//            arlist[0] = "Диана";
//            arlist[1] = 100;
//        }
//    }
//}

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



