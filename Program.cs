using System;
using System.Linq;

namespace Task14
{
    class Program
    {
        static void Main(string[] args) {
            var userPhrase = EnterPhrase();
            //  Разбиваем предложение на массив слов
            var words = userPhrase.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //  Вывод слов предложения в обратном порядке
            Console.Write("Обратное предложение: ");
            foreach (var word in words.Reverse()) { //  <-- Используем функцию Reverse из пространства имен System.Linq для решения задания
                Console.Write("{0} ", word);
            }
            Console.WriteLine();
            Console.WriteLine("Спасибо! Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }

        /// <summary>
        /// Возвращает предложение, введенное пользователем в виде строки
        /// </summary>
        /// <returns></returns>
        private static string EnterPhrase()
        {
            Console.Write("Введите предложение: ");
            var result = Console.ReadLine();
            Console.WriteLine();
            return result;
        }
    }
}
