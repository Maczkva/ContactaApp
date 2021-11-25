using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс, принимающий и возвращающий номер телефона учащегося.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        /// <summary>
        /// Метод, устанавливающий и возвращающий номер контакта.
        /// </summary>
        public long Number
        {
            get 
            { 
                return _number;
            }
            set
            {
                if (value.ToString()[0] != '7')
                {
                    throw new ArgumentException("Введите номер телефона," +
                        " начинающийся с 7.");
                }

                if (value > 99999999999)
                {
                    throw new ArgumentException("Вы ввели больше 11 цифр," +
                        " введите номер из 11 цифр.");
                }

                if (value < 10000000000)
                {
                    throw new ArgumentException("Вы ввели меньше 11 цифр," +
                        " введите номер, состоящий из 11 цифр.");
                }

                    _number = value;
            }
        }
    }


}
