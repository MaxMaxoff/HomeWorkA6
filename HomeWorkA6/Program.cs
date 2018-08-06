using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Библиотека для упрощения работы с консолью.
// https://github.com/MaxMaxoff/SupportLibrary
using SupportLibrary;

/// <summary>
/// Максим Торопов
/// Ярославль
/// https://github.com/MaxMaxoff
/// 
/// Домашняя работа "Алгоритмы и структуры данных"
/// 6 урок
/// </summary>

namespace HomeWorkA6
{
    class Program
    {
        /// <summary>
        /// 1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
        /// </summary>
        static void Task1()
        {
            SupportMethods.PrepareConsoleForHomeTask("1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов.\n");
            string str = SupportMethods.RequestString("Please type string: ");

            SupportMethods.Pause($"Hash: {HashFunction(str)}");
        }

        /// <summary>
        /// Hash function 1
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return alphabet+digits string</returns>
        static string HashFunction(string str)
        {
            string hash = String.Empty;
            // ASCII 48-57, 65-90 = 10 + 26 = 36
            int[] arr = new int[36] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 };
            char[] chArr = str.ToCharArray();
            char[] hashArr = new char[32];

            for (int i = 0; i < chArr.Length * 32; i++)
            {
                hashArr[i % 32] ^= (char)(arr[(int)(chArr[i % chArr.Length] * chArr.Length * i % 36)]);
            }

            for (int i = 0; i < hashArr.Length; i++)
                hash += (char)arr[((int)hashArr[i] % 36)];

            return hash;
        }

        /// <summary>
        /// 2. Переписать программу, реализующее двоичное дерево поиска.
        /// а) Добавить в него обход дерева различными способами;
        /// б) Реализовать поиск в двоичном дереве поиска;
        /// </summary>
        static void Task2()
        {

        }

        static void Task3()
        {

        }

        static void Main(string[] args)
        {
            do
            {
                SupportMethods.PrepareConsoleForHomeTask("1 - Task 1\n" +
                  "2 - Task 2\n" +
                  "3 - Task 3\n" +
                  "0 (Esc) - Exit\n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                        Task3();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
