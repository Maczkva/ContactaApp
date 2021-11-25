using System;
using System.IO;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс для сохранения данных в файл и загрузки из него.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Стандартный путь к файлу.
        /// </summary>
        public static readonly string _DefaultFileDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\Roaming" + "\\ContactApp" + "\\ContactApp.txt";

        /// <summary>
        /// Метод, выполняющий запись в файл 
        /// </summary>
        /// <param name="contact">Экземпляр проекта для сериализации</param>
        /// <param name="_DefaultFileDirectory">Путь к файлу</param>
        public static void SaveToFile(Project contact, string _DefaultFileDirectory)
        {
            JsonSerializer serializer = new JsonSerializer();

            var directoryFileContactApp = Path.GetDirectoryName(_DefaultFileDirectory);

            if (Directory.Exists(directoryFileContactApp))
            {
                Directory.CreateDirectory(directoryFileContactApp);
            }

            if (File.Exists(_DefaultFileDirectory))
            {
                File.Create(_DefaultFileDirectory).Close();
            }

            using (StreamWriter sw = new StreamWriter(_DefaultFileDirectory))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, contact);
            }
        }

        /// <summary>
        /// Метод, выполняющий чтение из файла 
        /// </summary>
        /// <param name="_DefaultFileDirectory">Путь к файлу</param>
        /// <returns>Экземпляр проекта, считанный из файла</returns>
        public static Project LoadFromFile(string _DefaultFileDirectory)
        {

            Project project = new Project();
            JsonSerializer serializer = new JsonSerializer();

            try
            {
                if (File.Exists(_DefaultFileDirectory))
                {
                    using (StreamReader sr = new StreamReader(_DefaultFileDirectory))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {                        
                        project = (Project)serializer.Deserialize<Project>(reader);
                    }
                }

                return project;
            }
            catch
            {
                return new Project();
            }
        }
    }
}
