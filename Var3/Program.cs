using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PloshadLib;

namespace Var3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "input.txt";
            string output = "output.txt";
          
            //Создание объекта FilrInfo
            FileInfo file = new FileInfo(input);
            //Проверка на существование файла
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден");

            }
            //Проверка на пустоту файла
            else if (file.Length == 0)
            {
                Console.WriteLine("Файл пустой");
            }
            else
            {
                try
                {   //Чтение
                    string[] lines = File.ReadAllLines(input);
                    //Добавление строк
                    string input2 = string.Join("\n", lines);
                    //Вызов метода
                    int result = Area.Calculate(input2);
                    File.WriteAllText(output, result.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            Console.ReadKey();
        }
    }
}
