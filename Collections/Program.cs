using System;
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
            13.4. Основные коллекции. Часть 2
            Если у нас много контактов, искать их в коллекции проще всего по какому-то одному элементу, который будет уникален. В данном случае по имени. 

            В массивах Array и списках List<T> мы можем обратиться к любому объекту, если знаем его индекс, то есть порядковый номер в коллекции, 
            но очевидно, что в данном случае нам это не подходит.  Гораздо удобнее было бы находить нужную информацию по имени, как в словаре. 

            System.Collections.Generic предоставляет нам как раз такую структуру данных.
            
            **************************
            Dictionary <TKey, TValue>
            **************************
            
            Соответственно, каждое значение словаря в отдельности является структурой KeyValuePair<TKey, TValue>.

            Рассмотрим возможности словаря на примере: см. ниже
                           
            По ключу также возможно изменять или удалять объекты: см. ниже 

            Класс словарей так же, как и другие коллекции, предоставляет методы Add и Remove для добавления и удаления элементов. 
            Только в случае словарей в метод Add передаются два параметра: ключ и значение. А метод Remove удаляет не по индексу, а по ключу.

            Вообще, быстрые операции по ключу — главное свойство и преимущество структуры данных словаря. Как и в List<T>, элементы свободно 
            добавляются и удаляются без ощутимых потерь в производительности, связанных со смещением объектов в памяти, то есть емкость словаря также может изменяться динамически.

            Словарь Dictionary <TKey, TValue> имеет ряд полезных методов и свойств. 

            Детально с ними можно ознакомиться в скринкасте или в таблице ниже:
            -------------------------------------------------------------------------------------------------------------------------------
            Методы

            Add()  Добавляет в словарь пару «ключ-значение»,              var items = new Dictionary<string, string>();
                   определяемую параметрами key и value.                  items.Add("гитара", "Струнный щипковый музыкальный инструмент");                  
                   Если ключ key уже находится в словаре,                 items.Add("барабан", "Ударный инструмент");  
                   то его значение изменено не будет, но будет            items.Add("тромбон", "Духовой инструмент");  
                   сгенерировано ArgumentException.	

            ContainsKey() Проверяет словарь на наличие запрашиваемого       // true
                          ключа. Вернёт true, если есть, иначе — false.	    bool guitarExists = items.ContainsKey("гитара");    
                                                                            // false    
                                                                            bool drumExists = items.ContainsKey("виолончель");
 
            ContainsValue() То же, что и ContainsKey, но проверяет          // true
            на наличие значения.	                                        bool exists = items.ContainsValue("Ударный инструмент");    


            Свойства

            Key Получить коллекцию ключей.	                               var items = new Dictionary<string, string>();                 
                                                                           items.Add("гитара", "Струнный щипковый музыкальный инструмент");
                                                                           items.Add("барабан", "Ударный инструмент");
                                                                           items.Add("тромбон", "Духовой инструмент"); 

                                                                           foreach (var c in items.Keys)
                                                                                  Console.WriteLine(c);
            
            Values  Получить коллекцию значений.                           foreach (var c in items.Values)                     	
                                                                                  Console.WriteLine(c); 
            -------------------------------------------------------------------------------------------------------------------------------

            Задания 13.4.4 
            Перепишите нашу телефонную книгу из юнита 3, используя словарь и класс Contact:

                public class Contact // модель класса
                {
                public Contact(string name, long phoneNumber, String email) // метод-конструктор
                     {
                    Name = name;
                    PhoneNumber = phoneNumber;
                    Email = email;
                     }

                public String Name {get;}
                public long PhoneNumber {get;}
                public String Email {get;}
                }

            Подумайте, нужно ли нам изменить класс Contact, либо стоит использовать как есть. Ответ см. ниже

            В примере выше мы с вами успешно реализовали телефонную книгу с использованием словаря. 

            Но сейчас все данные в нём хранятся в случайном порядке, то есть именно в таком виде, как добавляются. Список контактов 
            удобно просматривать, когда он как-то упорядочен, например по алфавиту.

            Мы конечно можем каждый раз при показе пользователю сортировать данные , но есть другой способ — использовать другую 
            подходящую для этого структуру данных.

            **************************
            SortedDictionary <TKey, TValue>
            **************************

            По сути эта структура данных аналогична словарю, но элементы в ней сортируются по значению ключа.

            Здесь стоит принять во внимание, что в плане производительности сортированный словарь будет медленнее обычного, но  когда 
            речь не идёт об очень больших объёмах данных и нужна сортировка по умолчанию, он может стать оптимальным решением.

            Чтобы понять механизм работы, создадим коллекцию и добавим в неё элементы в произвольном порядке:


            // Создаем сортированный словарь
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            // Добавим несколько элементов в случайном порядке
            sortedDictionary.Add("zebra", 5);
            sortedDictionary.Add("cat", 2);
            sortedDictionary.Add("dog", 9);
            sortedDictionary.Add("mouse", 4);
            sortedDictionary.Add("programmer", 100);
            // Ищем собаку
            if (sortedDictionary.ContainsKey("dog"))
                Console.WriteLine("Нашли собаку");
            // Ищем зебру
            if (sortedDictionary.ContainsKey("zebra"))
                Console.WriteLine("Нашли зебру");
            // Ищем обезьяну
            if (sortedDictionary.ContainsKey("ape"))
                Console.WriteLine("Нашли обезьяну");

            Console.WriteLine();

            // Теперь посмотрим, кто у нас живёт и в каком порядке
            Console.WriteLine("Посмотрим всех:");

            foreach (KeyValuePair<string, int> p in sortedDictionary)
                Console.WriteLine($"{p.Key} = {p.Value}");

            Нашли собаку
            Нашли зебру

            Посмотрим всех:
            cat = 2
            dog = 9
            mouse = 4
            programmer = 100
            zebra = 5

            */

        }
    }
}

//// Создадим словарь. Ключом будет строка, а значением - массив строк
//var cities = new Dictionary<string, string[]>(3 /* Размер (указывать необязательно))*/ );

//// Добавим новые значения
//cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
//cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
//cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });

////  Посмотрим всё что есть в словаре
//foreach (var citiesByCountry in cities)
//{
//    Console.Write(citiesByCountry.Key + ": ");
//    foreach (var city in citiesByCountry.Value)
//        Console.Write(city + " ");

//    Console.WriteLine();
//}

//Console.WriteLine();

//// Теперь попробуем вывести значения по ключу
//var russianCities = cities["Россия"];
//Console.WriteLine("Города России:");
//foreach (var city in russianCities)
//    Console.WriteLine(city);

////Вывод программы
////Россия: Москва Санкт-Петербург Волгоград
////Украина: Киев Львов Николаев Одесса
////Беларусь: Минск Витебск Гродно

////Города России:
////Москва
////Санкт - Петербург
////Волгоград

//Здесь мы сначала вывели все значения словаря, а потом попробовали достать нужное нам по ключу.

//// изменение объекта
//cities["Россия"] = new[] { "Мурманск", "Казань" };

//// удаление по ключу
//cities.Remove("Беларусь");


//using System;
//using System.Collections.Generic;
 
//namespace PhoneBook
//{
//    class Program
//    {
//        //  Объявим словарь с двумя значениями
//        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
//        {
//            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
//            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
//        };

//        static void Main(string[] args)
//        {
//            // Покажем весь список
//            Console.WriteLine("Текущий список контактов: ");
//            WriteAllContacts();

//            // Попробуем добавить новый контакт, если такого ещё нет
//            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

//            //  Выведем обновлённый список
//            Console.WriteLine("Обновленный список контактов: ");
//            WriteAllContacts();

//            //  Попробуем достать контакт для изменения данных
//            if (PhoneBook.TryGetValue("Диана", out Contact contact))
//                contact.PhoneNumber = 79990000001;

//            // И покажем результат после изменения
//            Console.WriteLine("Список после изменения: ");
//            WriteAllContacts();
//        }

//        // Метод для вывода словаря на консоль
//        public static void WriteAllContacts()
//        {
//            foreach (var contact in PhoneBook)
//                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
//            Console.WriteLine();
//        }

//        // Класс был изменен. Поле Name мы убрали,
//        // так как оно теперь будет ключом
//        // для поиска значений в словаре
//        public class Contact // модель класса
//        {
//            public Contact(long phoneNumber, String email) // метод-конструктор
//            {
//                PhoneNumber = phoneNumber;
//                Email = email;
//            }
//            public long PhoneNumber { get; set; }
//            public String Email { get; set; }
//        }
//    }
//}