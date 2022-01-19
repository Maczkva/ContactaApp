using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс со свойствами номера телефона.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private long _number;

        /// <summary>
        /// Свойство номера телефона.
        /// Поле должно быть числовым и содержать ровно 11 цифр. Первая цифра должна быть ‘7’.
        /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                if (value.ToString().Length != 11 || value.ToString()[0] != '7' )
                {
                    throw new ArgumentException(message: "Phone number must start with 7 and be 11 digits long");
                }
                _number = value;
            }
        }
    }
}