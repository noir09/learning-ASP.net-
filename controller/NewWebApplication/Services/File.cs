using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApplication.Services
{
    public class File
    {
        public void save(string text)
        {
            // создаем каталог для файла
            string path = @"C:\Users\Никита\source\repos\NewWebApplication\NewWebApplication\File";//@"D:\tgtg2.txt"
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fstream = new FileStream($@"{path}\F.txt", FileMode.Create))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

        }
    }
}
