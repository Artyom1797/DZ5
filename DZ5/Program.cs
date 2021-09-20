using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{    //Губарь Артём
    class Message
    {
        private static string[] separators = { ".", ",", "?", "!", "—", ";", ":", " " };
        /// <summary>
        /// Выводит слова, которые содержат не более n букв
        /// </summary>
        /// <param name="message">строка</param>
        /// <param name="n">максимальное кол-во букв</param>
        public static void AmountLetters (string message, int n)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= n)
                {
                    Console.Write($"{words[i]} ");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Удаляет слова, которые заканчиваются на символ "n"
        /// </summary>
        /// <param name="message">строка</param>
        /// <param name="n">заданный символ</param>
        public static void DeleteWords(string message, char n)
        {
            string[] words = message.Split();
            StringBuilder message1 = new StringBuilder(message);
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i][words[i].Length-1] == n)
                {
                    message1.Insert(i, " ");
                }
            }
            Console.WriteLine(message1.ToString());
            Console.ReadKey();
        }
        /// <summary>
        /// Находит самое длинное слово
        /// </summary>
        /// <param name="message">строка</param>
        public static void LongestWord(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int l = 0;
            int a = 0;
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > l)
                {
                    l = words[i].Length;
                    a = i;
                }

            }
            Console.WriteLine($"Самое длинное слово - {words[a]}");

        }
        /// <summary>
        /// Создаёт строку из самых длинных слов сообщения
        /// </summary>
        /// <param name="message">строка</param>
        public static void BigWords (string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder message1 = new StringBuilder();
            int l = 0;
            for (int i = 0; i < words.Length; i++ )
            {
                if (words[i].Length > l)
                {
                    l = words[i].Length;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == l)
                {
                    message1.Append($"{words[i]} ");
                }
            }
            Console.WriteLine("Строка из самых длинных слов сообщения");
            Console.WriteLine(message1);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            Console.WriteLine("====================");
            Console.WriteLine("1 - задача 1");
            Console.WriteLine("2 - задача 2");
            Console.WriteLine("0 - завершение работы программы");
            int TaskNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (TaskNumber)
                {
                    case 0:
                        Console.WriteLine("завершение работы программы...");
                        Console.ReadKey();
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Title = "Проверка корректности логина";
            while (true)
            {
                Console.WriteLine("Введите логин");                     
                string str = Console.ReadLine();
                char[] login = str.ToCharArray();
                int sum = 0;
                int a;
                for (int i = 0; i < login.Length; i++)
                {
                    sum+=1;
                }
                if (sum < 2 || sum > 10)
                {
                    a = 1;
                }
                else 
                {
                    a = 2;
                }
                

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Логин не может быть меньше двух и больше десяти символов");
                        break;
                    case 2:
                        int sum1 = 0;
                        for (int i = 0; i < login.Length; i++)
                        {
                            UnicodeCategory category = char.GetUnicodeCategory(login[i]);
                          
                            switch(category)
                            {
                                case UnicodeCategory.DecimalDigitNumber:
                                    Console.WriteLine($"Символ {login[i]} подходит");
                                    sum1++;
                                    break;

                                case UnicodeCategory.LowercaseLetter:
                                    Console.WriteLine($"Символ {login[i]} подходит");
                                    sum1++;
                                    break;

                                case UnicodeCategory.UppercaseLetter:
                                    Console.WriteLine($"Символ {login[i]} подходит");
                                    sum1++;
                                    break;

                                default:
                                    Console.WriteLine($"Символ {login[i]} не подходит");
                                    break;

                            }
                          
                        }

                        if (sum1 == login.Length)
                        {
                            UnicodeCategory category = char.GetUnicodeCategory(login[0]);
                            if (category == UnicodeCategory.DecimalDigitNumber)
                            {
                                Console.WriteLine("Логин не может начинаться с цифры");
                            }
                            else Console.WriteLine("Логин составлен верно");
                        }
                        else Console.WriteLine("Логин составлен неверно, повторите попытку");

                        break;

                }
                
                

            }




        }

        static void Task2()
        {
            while(true)
            { 
                Console.WriteLine("Введите номер подраздела задачи");
                Console.WriteLine("===============================");
                Console.WriteLine("1 - a");
                Console.WriteLine("2 - b");
                Console.WriteLine("3 - c");
                Console.WriteLine("4 - d");
                Console.WriteLine("0 - завершение работы программы");
                int number = int.Parse(Console.ReadLine());
            
            
                switch (number)
                {
                    case 1:
                        Task2a();
                        break;
                    case 2:
                        Task2b();
                        break;
                    case 3:
                        Task2c();
                        break;
                    case 4:
                        Task2d();
                        break;
                    case 0:
                        Console.WriteLine("завершение работы программы...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Некорректный номер подраздела. Повторите ввод...");
                        break;






                }
            }
        }

        static void Task2a()
        {
            Console.WriteLine("Выведет те слова сообщения, которые содержат не более n букв");
            Console.WriteLine("Скопируйте сообщение...");
            string message = Console.ReadLine();
            Console.WriteLine("Укажите количество (n) букв...");
            int n = int.Parse(Console.ReadLine());
            Message.AmountLetters(message, n);
        }

        static void Task2b()
        {
            Console.WriteLine("Удаляет все слова, которые заканчиваются на символ n");
            Console.WriteLine("Скопируйте сообщение...");
            string message = Console.ReadLine();
            Console.WriteLine("Укажите симлов n...");
            char n = char.Parse(Console.ReadLine());
            Message.DeleteWords(message, n);
        }

        static void Task2c()
        {
            Console.WriteLine("Находит самое длинное слово");
            Console.WriteLine("Скопируйте сообщение...");
            string message = Console.ReadLine();
            Message.LongestWord(message);
        }

        static void Task2d()
        {
            Console.WriteLine("Создаёт строку из самых длинных слов сообщение");
            Console.WriteLine("Скопируйте сообщение...");
            string message = Console.ReadLine();
            Message.BigWords(message);
        }
        
    }
    
    
}
        

    

