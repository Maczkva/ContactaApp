using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        public List<Contact> PrepareList()
        {
            var sourceProject = new List<Contact>();
            var phoneNumber = new PhoneNumber
            {
                Number = 79996665544
            };
            sourceProject.Add(new Contact
            {
                Name = "BName",
                Surname = "BSurname",
                DateOfBirth = DateTime.Now,
                IdVk = "B434234",
                Email = "Bhogger@bk.com",
                PhoneNumber = phoneNumber
            });
            sourceProject.Add(new Contact
            {
                Name = "CName",
                Surname = "CSurname",
                DateOfBirth = DateTime.Now,
                IdVk = "C434234",
                Email = "Chogger@bk.com",
                PhoneNumber = phoneNumber
            });
            sourceProject.Add(new Contact
            {
                Name = "AName",
                Surname = "ASurname",
                DateOfBirth = DateTime.Now,
                IdVk = "A434234",
                Email = "Ahogger@bk.com",
                PhoneNumber = phoneNumber
            });
            return sourceProject;
        }

        [Test]
        public void SortContacts_GoodSort_ReturnSortedContacts()
        {
            //Setup
            var sourceContacts = new Project {Contacts = PrepareList()};
            var expectedContacts = sourceContacts.Contacts.Select(contact => 
                contact.Clone() as Contact).ToList();
            expectedContacts = (from u in expectedContacts orderby u.Surname select u).ToList();

            //Act
            List<Contact> actualContacts = sourceContacts.SortContacts(sourceContacts.Contacts);
         
            //Assert
            Assert.AreEqual(expectedContacts, actualContacts);
        }

        [Test]
        public void SortContacts_GoodSortAndFind_ReturnSortedContacts()
        {
            //Setup
            var sourceProject = new Project {Contacts = PrepareList()};
            var expectedContacts = new List<Contact> {sourceProject.Contacts[0].Clone() as Contact};

            //Act
            var actualProject = 
                sourceProject.SortContacts("BName", sourceProject.Contacts);

            //Assert
            Assert.AreEqual(expectedContacts, actualProject);
        }

        [Test]
        public void SortContacts_SortAndFindWithEmptyString_ReturnSortedContacts()
        {
            //Setup
            var sourceProject = new Project {Contacts = PrepareList()};
            var expectedProject = sourceProject.Contacts;

            //Act
            var actualProject = sourceProject.SortContacts("", sourceProject.Contacts);

            //Assert
            Assert.AreEqual(expectedProject, actualProject);
        }
    }
}
