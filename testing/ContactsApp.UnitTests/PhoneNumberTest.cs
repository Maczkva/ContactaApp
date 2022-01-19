using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {

        [Test]
        public void PhoneNumber_GoodPhoneNumber_ReturnsSamePhoneNumber()
        {
            //Setup
            var sourcePhoneNumber = 79996198754;
            var phoneNumber = new PhoneNumber();
            var expectedPhoneNumber = sourcePhoneNumber;

            //Act
            phoneNumber.Number = sourcePhoneNumber;
            var actualPhoneNumber = phoneNumber.Number;

            //Assert
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }

        [Test]
        public void PhoneNumber_WrongPhoneNumberBegin_ThrowsException()
        {
            //Setup
            var phoneNumber = new PhoneNumber();
            var sourceNumber = 87776665544;
            

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    phoneNumber.Number = sourceNumber;
                }
            );
        }

        [Test]
        public void PhoneNumber_TooLongPhoneNumber_ThrowsException()
        {
            //Setup
            var phoneNumber = new PhoneNumber();
            var sourceNumber = 877766655477777777;

            //Assert
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    phoneNumber.Number = sourceNumber;
                }
            );
        }
    }
}
