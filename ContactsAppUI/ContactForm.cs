using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    /// <summary>
    /// Класс для добавления и редактирования контактов.
    /// </summary>
    public partial class ContactForm : Form
    {
        private Contact _tempContact;
        /// <summary>
        /// Временный проект для добавления или редактирования контакта.
        /// </summary>
        public Contact TempContact
        {
            get => _tempContact;
            set
            {
                _tempContact = value;
                surnameTextBox.Text = value.Surname;
                nameTextBox.Text = value.Name;
                idVkTextBox.Text = value.IdVk;
                emailTextBox.Text = value.Email;
                if(value.PhoneNumber.Number != 0)
                    phoneTextBox.Text = value.PhoneNumber.Number.ToString();
                birthDatePicker.Value = value.BirthDate;
            }
        }

        public ContactForm()
        {
            InitializeComponent();
            birthDatePicker.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Действие при нажатии кнопки Ok.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            NewContact();
        }

        /// <summary>
        /// Действие при нажатии кнопки Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Действие при закрытии формы.
        /// </summary>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Cancel) return;
            if (surnameTextBox.Text == "" && surnameTextBox.Text == "" && phoneTextBox.Text == "" &&
                emailTextBox.Text == "" && idVkTextBox.Text == "")
            {
                return;
            }
            var dialogAnswer = MessageBox.Show(@"The entered data will not be saved.",
                @"Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogAnswer == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Создание контакта для добавления или редактирования.
        /// </summary>
        private void NewContact()
        {
            try
            {
                CheckCorrect();
                TempContact.Surname = surnameTextBox.Text;
                TempContact.Name = nameTextBox.Text;
                TempContact.IdVk = idVkTextBox.Text;
                TempContact.Email = emailTextBox.Text;
                TempContact.BirthDate = birthDatePicker.Value;
                var phoneNumber = new PhoneNumber
                {
                    Number = Convert.ToInt64(phoneTextBox.Text)
                };
                TempContact.PhoneNumber = phoneNumber;
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Проверка данных на заполненность и верность заполнения.
        /// </summary>
        private void CheckCorrect()
        {
            if (surnameTextBox.BackColor == Color.LightCoral)
            {
                throw new ArgumentException(message: @"The name was entered incorrectly.
It must be composed of the letters of the Russian alphabet.
You can enter a double name separated by a dash.");
            }
            if (nameTextBox.BackColor == Color.LightCoral)
            {
                throw new ArgumentException(message: @"The surname was entered incorrectly.
It must be composed of the letters of the Russian alphabet.
You can enter a double name separated by a dash.");
            }
            if (phoneTextBox.BackColor == Color.LightCoral)
            {
                throw new ArgumentException(message: @"The phone number was entered incorrectly.
The number must be digits and no longer than eleven digits.");
            }
            if (emailTextBox.BackColor == Color.LightCoral)
            {
                throw new ArgumentException(message: @"Email entered incorrectly.
Email should be composed of Latin letters, and also contain @ and a dot.");
            }
            if (idVkTextBox.BackColor == Color.LightCoral)
            {
                throw new ArgumentException(message: @"IdVK entered incorrectly.
VkId should consist of Latin letters.It is possible to enter a underscore between the two parts.");
            }
        }

        /// <summary>
        /// Паттерн имени и фамилии. Русские буквы и возможность написания тире для двойных имен.
        /// </summary>
        private const string RegexName = "^[а-яА-Яa-zA-Z]+(-[а-яА-Я]+)?$";

        /// <summary>
        /// Паттерн номера телефона где номер начинается с 7 и имеет длину в 11 цифр. 
        /// </summary>
        private const string RegexPhoneNumber = "^7[0-9]{10,10}$";

        /// <summary>
        /// Паттерн емейла. Латинские буквы также проверка ввода @ и точки.
        /// </summary>
        private const string RegexEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        /// <summary>
        /// Паттерн айди вк. Ввод латинских букв и возможность ввода _ между словами.
        /// </summary>
        private const string RegexIdVk = "^[a-zA-Z0-9]+(_[a-zA-Z0-9]+)+(_[a-zA-Z0-9]+)?$";

        /// <summary>
        /// Проверка фамилии на ввод по патерну.
        /// </summary>
        private void SurnameCheck(object sender, EventArgs e)
        {
            const string pattern = RegexName;
            CheckRegex(surnameTextBox, pattern);
        }

        /// <summary>
        /// Проверка имени на ввод по патерну.
        /// </summary>
        private void NameCheck(object sender, EventArgs e)
        {
            const string pattern = RegexName;
            CheckRegex(nameTextBox, pattern);
        }

        /// <summary>
        /// Проверка номера на ввод по патерну.
        /// </summary>
        private void PhoneCheck(object sender, EventArgs e)
        {
            const string pattern = RegexPhoneNumber;
            CheckRegex(phoneTextBox, pattern);
        }

        /// <summary>
        /// Проверка емейла на ввод по патерну.
        /// </summary>
        private void EmailCheck(object sender, EventArgs e)
        {
            const string pattern = RegexEmail;
            CheckRegex(emailTextBox, pattern);
        }

        /// <summary>
        /// Проверка айди вк на ввод по патерну.
        /// </summary>
        private void IdVkCheck(object sender, EventArgs e)
        {
            const string pattern = RegexIdVk;
            CheckRegex(idVkTextBox, pattern);
        }

        /// <summary>
        /// Проверка текстбокса по паттерну.
        /// </summary>
        private static void CheckRegex(Control textBox, string pattern)
        {
            if (textBox.Text == "")
            {
                textBox.BackColor = Color.White;
                return;
            }
            textBox.BackColor = !Regex.IsMatch(textBox.Text, pattern) ? Color.LightCoral : Color.White;
        }
    }
}
