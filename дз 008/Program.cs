using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Андрей\OneDrive\Документы\проекты C#";// в этом каталоге

            string path2 = @"1"; // название католога
            string path3 = @"2"; // название католога
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            dirInfo.CreateSubdirectory(path2); // создал подкатолог 1
            dirInfo.CreateSubdirectory(path3);   // создал подкатолог 2





            string path4 = dirInfo.CreateSubdirectory(path2) + "\\dirinfo.txt"; // делаем путь для создания файла 
            string path5 = dirInfo.CreateSubdirectory(path3) + "\\dirinfo.txt"; // делаем путь для создания файла

            File.WriteAllText(path4, "1"); // создаем файл
            File.WriteAllText(path5, "2");  // создаем файл



            string q = $"Время создания подкаталога: {Directory.GetCreationTime(path4)}"; // считываем время создания 
            string q1 = $"Время создания подкаталога: {Directory.GetCreationTime(path5)}"; // считываем время создания 

            File.WriteAllText(path4, q); // перезаписываем данные в файле на дату зоздания подкаталога
            File.WriteAllText(path5, q1);  // перезаписываем данные в файле на дату зоздания подкаталога

        }
    }
}
