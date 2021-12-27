using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    /// <summary>
    /// Главное окно программы.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Локальное хранилище контактов.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Проект для поиска.
        /// </summary>
        private Project _tempProject = new Project();

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private readonly string _filePath = ProjectManager.FilePath();
        
        /// <summary>
        /// Загрузка данных из файла.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadFromFile(_filePath);
            if (_project.Contacts.Count == 0)
            {
                return;
            }
            _tempProject = _project;
            UpdateContactsList(null);
            BirthDaysContacts();
            ProjectManager.SaveToFile(_project, _filePath);
        }

        /// <summary>
        /// Вывод данных контакта на главную форму.
        /// </summary>
        private void ContactsView(IReadOnlyList<Contact> contactsToView)
        {
            var index = ContactsListBox.SelectedIndex;
            surnameTextBox.Text = contactsToView[index].Surname;
            nameTextBox.Text = contactsToView[index].Name;
            phoneTextBox.Text = $@"+{contactsToView[index].PhoneNumber.Number}";
            emailTextBox.Text = contactsToView[index].Email;
            idVkTextBox.Text = contactsToView[index].IdVk;
            birthDateBox.Text = contactsToView[index].DateOfBirth.ToString("dd.MM.yyyy");
        }

        /// <summary>
        /// Очищения полей для вывода контакта.
        /// </summary>
        private void ClearContactsView()
        {
            surnameTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            emailTextBox.Text = "";
            idVkTextBox.Text = "";
            birthDateBox.Text = "";
        }


        /// <summary>
        /// Добавление контакта.
        /// </summary>
        private void AddContact()
        {
            var newContact = new Contact { PhoneNumber = new PhoneNumber() };
            var contactForm = new ContactForm { TempContact = newContact };
            var dialogResult = contactForm.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            _project.Contacts.Add(contactForm.TempContact);
            _project.Contacts = Project.SortContacts(_project.Contacts);
            UpdateContactsList(contactForm.TempContact);
            ProjectManager.SaveToFile(_project, _filePath);
        }

        /// <summary>
        /// Редактирование контакта.
        /// </summary>
        private void EditContact()
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Select the contact.", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var projectToList = Project.SortContacts(findTextBox.Text, _project);
                var selectedIndex = ContactsListBox.SelectedIndex;
                var selectedContact = projectToList.Contacts[selectedIndex];
                var contactForm = new ContactForm { TempContact = selectedContact };
                var dialogResult = contactForm.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                var index = _project.Contacts.FindIndex(x => x == contactForm.TempContact);
                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, contactForm.TempContact);
                _project.Contacts = Project.SortContacts(_project.Contacts);
                UpdateContactsList(contactForm.TempContact);
                ProjectManager.SaveToFile(_project, _filePath);
            }
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        private void DeleteContact()
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select the contact.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedIndex = ContactsListBox.SelectedIndex;
                var result = MessageBox.Show($@"Do you really want to delete this contact: 
                    {_project.Contacts[selectedIndex].Surname}?", @"Confirmation",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result != DialogResult.OK)
                {
                    return;
                }
                _project.Contacts.RemoveAt(selectedIndex);
                ContactsListBox.Items.RemoveAt(selectedIndex);
                ProjectManager.SaveToFile(_project, _filePath);
                if (ContactsListBox.Items.Count > 0)
                {
                    ContactsListBox.SelectedIndex = 0;
                }
                ContactsListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Вывод контактов у которых день рождения.
        /// </summary>
        private void BirthDaysContacts()
        {
            var birthDaysContacts = new Project { Contacts = 
                Project.BirthDayContactsFind(DateTime.Today, _project) };
            if (birthDaysContacts.Contacts.Count == 0)
            {
                return;
            }
            birthContactsLabel.Text = "";
            for (var index = 0; index < birthDaysContacts.Contacts.Count; index++)
            {
                var contact = birthDaysContacts.Contacts[index];
                birthContactsLabel.Text += contact.Surname;
                if (index < birthDaysContacts.Contacts.Count - 1)
                {
                    birthContactsLabel.Text += @", ";
                }
            }
        }

        /// <summary>
        /// Сортировка контактов.
        /// </summary>
        private void UpdateContactsList(Contact contact)
        {
            var projectToList = Project.SortContacts(findTextBox.Text, _project);
            var index = projectToList.Contacts.FindIndex(x => x == contact);
            ContactsListBox.Items.Clear();
            foreach (var t in projectToList.Contacts)
            {
                ContactsListBox.Items.Add(t.Surname);
            }
            if (index == -1 && ContactsListBox.Items.Count != 0)
            {
                index = 0;
            }
            ContactsListBox.SelectedIndex = index;
            if (index == -1)
            {
                ClearContactsView();
            }
            _tempProject = projectToList;
        }

        /// <summary>
        /// Добавление контакта по нажатию кнопки add.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Редактирование контакта по нажатию кнопки edit.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Удаление контакта по нажатию кнопки remove.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        /// Изменение текста в поле поиска.
        /// </summary>
        private void FindTextBoxText_Changed(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0)
            {
                var selectedContact = _tempProject.Contacts[ContactsListBox.SelectedIndex];
                UpdateContactsList(selectedContact);
            }
            else
            {
                UpdateContactsList(null);
            }
        }

        /// <summary>
        /// Добавление контакта через меню.
        /// </summary>
        private void AddToolStripMenu_ItemClick(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Редактирование контакта через меню.
        /// </summary>
        private void EditContactToolStripMenu_ItemClick(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Удаление контакта через меню.
        /// </summary>
        private void RemoveContactToolStripMenu_ItemClick(object sender, EventArgs e)
        {
            DeleteContact();
        }

        /// <summary>
        /// Вызов окна About.
        /// </summary>
        private void AboutToolStripMenu_ItemClick(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        /// <summary>
        /// Выход через меню.
        /// </summary>
        private void ExitToolStripMenu_ItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Вызов окна About по горячей клавише F1.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowAboutForm();
            }
        }

        /// <summary>
        /// Вывод данных контакта на главную форму.
        /// </summary>
        private void ContactsListBoxSelected_IndexChanged(object sender, EventArgs e)
        {
            ContactsView(Project.SortContacts(findTextBox.Text, _project).Contacts);
        }

        /// <summary>
        /// Сохранение при выходе из программы.
        /// </summary>
        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_project, _filePath);
        }

        /// <summary>
        /// Вызов окна About.
        /// </summary>
        private static void ShowAboutForm()
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
