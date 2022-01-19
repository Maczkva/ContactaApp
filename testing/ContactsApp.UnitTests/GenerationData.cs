using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ContactsApp.UnitTests
{
    class Common
    {
        public static string DataFolderForTest()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + "\\TestData";
        }

        public static string FilePath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + "\\ContactsApp\\Contacts.json";
        }

        public static string DirectoryPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return path + "\\ContactsApp\\";
        }

    }
}
