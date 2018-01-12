using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormUtils1;
using ConsoleUtils;
using ProgramUtils;
namespace Раздел_10_номер_6_console
{
    class Program
    {
        static bool ConfirmAction(string question)
        {
            Console.Write(question + " (y/n): ");

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);

            Console.WriteLine();

            return keyInfo.Key == ConsoleKey.Y;
        }
        static int[,] ReadArrFromFile()
        {
            while (true)
            {
                try
                {
                    string filePath = ConsoleUtils.IOUtils.ReadValueFromConsole<string>("путь к входному файлу");


                    string arrText = FilesUtils.Read(filePath);
                    return DataConverter.StrToArray2D<int>(arrText);
                }
                catch (Exception e)
                {

                    ConsoleUtils.IOUtils.ShowError("Невозможно считать данные из этого файла");
                }
            }
        }
        static int[,] ReadArrFromConsole()
        {
            return ConsoleUtils.IOUtils.ReadArray2DFromConsole<int>("массив чисел");
        }
        public static void SaveResultToFile(string answer)
        {
            while (true)
            {
                try
                {
                    string filePath = ConsoleUtils.IOUtils.ReadValueFromConsole<string>("путь к выходному файлу");

                    FilesUtils.Write(filePath, answer);
                    return;
                }
                catch (Exception e)
                {

                    ConsoleUtils.IOUtils.ShowError("Невозможно записать данные в этот файл");
                }
            }
        }
        static int Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Добро пожаловать в программу !" +
"" + Environment.NewLine + Environment.NewLine);


                int[,] arr;
                List<Line> list = new List<Line>();


                if (ConfirmAction("Желаете ли вы считать данные из файла?"))
                {
                    arr = ReadArrFromFile();
                }
                else
                {
                    arr = ReadArrFromConsole();
                }
                for (int r = 0; r < arr.GetLength(0); r++)  
                    {

                        int c = 0;
                        Line rec = new Line(arr[r, c], arr[r,c+1]);
                        list.Add(rec);

                      
                    }


                        ProgramLogic arrayUtils = new ProgramLogic(list);


                
                string result1 = arrayUtils.Result().ToString();

                Console.WriteLine("Ответ : {0}", result1);


                if (ConfirmAction("Желаете ли вы сохранить резултат работы программы в файл?"))
                {
                    SaveResultToFile(result1);
                }


                if (ConfirmAction("Продолжить работу с программой?"))
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            return 0;
        }
    }
}
