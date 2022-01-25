using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Вариант №1");
            Console.WriteLine("Автор: Никита Агановский");
            

            Console.WriteLine("");

            string filename = "TextFile1.txt";
            int size = file_reader.SizeMas(filename);
            object[,] mas = new object[size, 7];

            //чтение информации из файла и запись в массив
            file_reader.Read(filename, mas);


            for (int i = 0; i < size; i++)
            {
                string num = mas[i, 0].ToString();
                string fname = mas[i, 1].ToString();
                string lname = mas[i, 2].ToString();
                string mname = mas[i, 3].ToString();
                string start = mas[i, 4].ToString();
                string finish = mas[i, 5].ToString();
                string club = mas[i, 6].ToString();

                Console.WriteLine("|" + num + " " + "|" + " " + fname + " " + "|" + " " + lname + " " + "|" + " " + mname + " " + "|" + " " + start + " " + "|" + " " + finish + " " + "|" + " " + club);

            }
            Console.ReadKey();
        }
    }
}
