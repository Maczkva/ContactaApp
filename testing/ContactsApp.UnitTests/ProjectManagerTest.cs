using System;
using System.IO;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test]
        public void SaveToFile_CorrectProject_FileSavedCorrectly()
        {
            //Setup
            var sourceProject = PrepareProject();
            var testDataFolder = GenerationData.DataFolderForTest();
            var actualFileName = testDataFolder + @"\actualProject.json";
            var expectedFileName = testDataFolder + @"\expectedProject.json";
            if (File.Exists(actualFileName))
            {
                File.Delete(actualFileName);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject, actualFileName, testDataFolder);

            var isFileExist = File.Exists(actualFileName);
            Assert.AreEqual(true, isFileExist);

            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void SaveToFile_CreateFolder_FolderIsExist()
        {
            //Setup
            var project = PrepareProject();
            
            var testDataFolder = GenerationData.DataFolderForTest()+"CreateTest";
            var testFileName = testDataFolder + @"CreateFolderTest";
            if (Directory.Exists(testDataFolder))
            {
                Directory.Delete(testDataFolder);
            }

            //Act
            ProjectManager.SaveToFile(project, testFileName, testDataFolder);

            //Assert
            Assert.IsTrue(Directory.Exists(testDataFolder));
        }

        [Test]
        public void LoadFromFile_CorrectProject_FileLoadedCorrectly()
        {
            //Setup
            var expectedProject = PrepareProject();
            var testDataFolder = GenerationData.DataFolderForTest();
            var testFileName = testDataFolder + @"\expectedProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);
            
            //Assert
            Assert.AreEqual(expectedProject.Contacts, actualProject.Contacts);
        }
        
        [Test]
        public void LoadFromFile_UnCorrectFile_ReturnEmptyProject()
        {
            //Setup
            var testDataFolder = GenerationData.DataFolderForTest();
            var testFileName = testDataFolder + @"\defectiveProject.json";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.IsEmpty(actualProject.Contacts);
        }

        [Test]
        public void LoadFromFile_UnCorrectPath_ReturnEmptyProject()
        {
            //Setup
            var testFileName = GenerationData.DataFolderForTest()+"wrong";

            //Act
            var actualProject = ProjectManager.LoadFromFile(testFileName);

            //Assert
            Assert.IsEmpty(actualProject.Contacts);
        }
        
        [Test]
        public void FilePath_GoodFilePath_ReturnSamePath()
        {
            //Setup
            var expectedPath = GenerationData.FilePath();

            //Act
            var actualPath = ProjectManager.FilePath();

            //Assert
            Assert.AreEqual(expectedPath, actualPath);
        }

        [Test]
        public void DirectoryPath_GoodDirectoryPath_ReturnSameDirectory()
        {
            //Setup
            var expectedPath = GenerationData.DirectoryPath();

            //Act
            var actualPath = ProjectManager.DirectoryPath();

            //Assert
            Assert.AreEqual(expectedPath, actualPath);
        }
        public Project PrepareProject()
        {
            var sourceProject = new Project();
            var phoneNumber = new PhoneNumber
            {
                Number = 79996665544
            };
            sourceProject.Contacts.Add(new Contact()
            {
                Name = "BName",
                Surname = "BSurname",
                DateOfBirth = DateTime.Parse("03-06-2012"),
                IdVk = "B434234",
                Email = "Bhogger@bk.com",
                PhoneNumber = phoneNumber
            });
            sourceProject.Contacts.Add(new Contact()
            {
                Name = "CName",
                Surname = "CSurname",
                DateOfBirth = DateTime.Parse("03-06-2012"),
                IdVk = "C434234",
                Email = "Chogger@bk.com",
                PhoneNumber = phoneNumber
            });
            sourceProject.Contacts.Add(new Contact()
            {
                Name = "AName",
                Surname = "ASurname",
                DateOfBirth = DateTime.Parse("03-06-2012"),
                IdVk = "A434234",
                Email = "Ahogger@bk.com",
                PhoneNumber = phoneNumber
            });
            return sourceProject;
        }
    }
}
