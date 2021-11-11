using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, принимающий и возвращающий номер телефона учащегося.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        public long Number
        {
            get { return _number; }
            set
            {

                if (value.ToString()[0] != '8')
                {
                    throw new ArgumentException("Введите номер телефона, начинающийся с 8.");
                }

                if (value > 99999999999)
                {
                    throw new ArgumentException("Вы ввели больше 11 цифр, введите номер из 11 цифр.");
                }

                if (value < 10000000000)
                {
                    throw new ArgumentException("Вы ввели меньше 11 цифр, введите номер, состоящий из 11 цифр.");
                }

                else
                {
                    _number = value;
                }
            }
        }
    }


}
