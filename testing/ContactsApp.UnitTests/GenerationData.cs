using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс созданный для генерации данных
    /// </summary>
    class GenerationData
    {
        /// <summary>
        /// Обращается к пути
        /// </summary>
        public static string DataFolderForTest()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + "\\TestData";
        }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public static string FilePath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + "\\ContactsApp\\Contacts.json";
        }
        /// <summary>
        /// Директория файла
        /// </summary>
        public static string DirectoryPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + "\\ContactsApp\\";
        }

    }
}
