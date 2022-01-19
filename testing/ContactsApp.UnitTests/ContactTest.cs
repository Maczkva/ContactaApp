using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        public Contact PrepareContact()
        {
            var sourceNumber = 79996196969;
            var phoneNumber = new PhoneNumber
            {
                Number = sourceNumber
            };
            var contact = new Contact
            {
                Name = "John",
                Surname = "Smith",
                DateOfBirth = DateTime.Now,
                PhoneNumber = phoneNumber,
                Email = "white@bk.com",
                IdVk = "463723"
            };
            return contact;
        }

        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            //Setup
            var contact = new Contact();
            const string sourceName = "John";
            const string expectedName = sourceName;

            //Act
            contact.Name = sourceName;
            var actualName = contact.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [TestCase("")]
        [TestCase("012345678901234567890123456789012345678901234567890123456789")]
        public void Name_WrongName_ThrowsException(string wrongName)
        {
            //Setup
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    contact.Name = wrongName;
                }
            );
        }

        [Test]
        public void Name_ChangeNameRegister_ReturnsRegisterChangedName()
        {
            //Setup
            var contact = new Contact();
            const string sourceName = "john";
            const string expectedName = "John";

            //Act
            contact.Name = sourceName;
            var actualName = contact.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Surname_GoodSurname_ReturnsSameSurname()
        {
            //Setup
            var contact = new Contact();
            const string sourceSurname = "Smith";
            const string expectedSurname = sourceSurname;

            //Act
            contact.Surname = sourceSurname;
            var actualSurname = contact.Surname;

            //Assert
            Assert.AreEqual(expectedSurname, actualSurname);
        }

        [TestCase("")]
        [TestCase("012345678901234567890123456789012345678901234567890123456789")]
        public void Surname_WrongSurname_ThrowsException(string wrongName)
        {
            //Setup
            var contact = new Contact();

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    contact.Surname = wrongName;
                }
            );
        }
        
        [Test]
        public void Surname_ChangeSurnameRegister_ReturnsRegisterChangedSurname()
        {
            //Setup
            var contact = new Contact();
            const string sourceSurname = "john";
            const string expectedSurname = "John";

            //Act
            contact.Surname = sourceSurname;
            var actualSurname = contact.Surname;

            //Assert
            Assert.AreEqual(expectedSurname, actualSurname);
        }

        [Test]
        public void PhoneNumber_GoodPhoneNumber_ReturnsSamePhoneNumber()
        {
            //Setup
            var contact = new Contact();
            var sourcePhoneNumber = 79996198754;
            var phoneNumber = new PhoneNumber();
            var expectedPhoneNumber = sourcePhoneNumber;
            phoneNumber.Number = sourcePhoneNumber;

            //Act
            contact.PhoneNumber = phoneNumber;
            var actualPhoneNumber = contact.PhoneNumber.Number;

            //Assert
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }

        [Test]
        public void Email_GoodEmail_ReturnsSameEmail()
        {
            //Setup
            var contact = new Contact();
            const string sourceEmail = "thiswhitenike@gmail.com";
            const string expectedEmail = sourceEmail;

            //Act
            contact.Email = sourceEmail;
            var actualEmail = contact.Email;

            //Assert
            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test]
        public void Email_TooLongEmail_ThrowsException()
        {
            //Setup
            var contact = new Contact();
            var sourceEmail = "012345678901234567890123456789012345678901234567890123456789";

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    contact.Email = sourceEmail;
                }
            );
        }

        [Test]
        public void IdVk_GoodIdVk_ReturnsSameIdVk()
        {
            //Setup
            var contact = new Contact();
            const string sourceIdVk = "white_dog";
            const string expectedIdVk = sourceIdVk;

            //Act
            contact.IdVk = sourceIdVk;
            var actualIdVk = contact.IdVk;

            //Assert
            Assert.AreEqual(expectedIdVk, actualIdVk);
        }

        [Test]
        public void IdVk_TooLongIdVk_ThrowsException()
        {
            //Setup
            var contact = new Contact();
            var sourceEmail = "012345678901234567890123456789012345678901234567890123456789";

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    contact.IdVk = sourceEmail;
                }
            );
        }

        [Test]
        public void BirthDate_GoodBirthDate_ReturnsSameBirthDate()
        {
            //Setup
            var contact = new Contact();
            var sourceBirthDate = DateTime.Now;
            var expectedBirthDate = sourceBirthDate;

            //Act
            contact.DateOfBirth = sourceBirthDate;
            var actualBirthDate = contact.DateOfBirth;

            //Assert
            Assert.AreEqual(expectedBirthDate, actualBirthDate);
        }

        [Test]
        public void BirthDate_OutOfRangeBirthDate_ThrowsException()
        {
            //Setup
            var contact = new Contact();
            var sourceBirthDate = new DateTime(2023, 1, 1);

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    contact.DateOfBirth = sourceBirthDate;
                }
            );
        }

        [Test]
        public void Clone_GoodClone_ReturnsSameObject()
        {
            //Setup
            var expectedContact = PrepareContact();

            //Act
            var actualContact = expectedContact.Clone() as Contact;

            //Assert
            Assert.AreEqual(expectedContact, actualContact);
        }
    }
}
