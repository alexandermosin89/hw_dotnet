using System;
using System.IO;

namespace HW._02.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Указываем путь считываемого файла, запускаем потоковое чтение
            //2. Проводим потоковое чтение до конца текста
            //3. Делим строки на массив подстрок
            //4. Освобождаем ресурсы
            //5. Создаем массив байтовых значений
            //6. Выполняем обход массива по заданным критериям
            //7. Выполняем конвертирование переменной в байтовую
            //8. Записываем массив байтовыми значениями
            //9. Записываем все байты в файл
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            textReader.Dispose();
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}
