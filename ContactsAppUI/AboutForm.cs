using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ContactsAppUI
{
    /// <summary>
    /// Класс с интерфейсом окна About.
    /// </summary>
    public partial class AboutForm : Form
    {

        public AboutForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрытие окна на кнопку.
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Переход на сайт репозитория.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Click_Git(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Maczkva/ContactsApp");
        }

        /// <summary>
        /// Переход к мейлу.
        /// </summary>
        private void Click_Mail(object sender, EventArgs e)
        {
            Process.Start("mailto://amaczkovskaya@gmail.com");
        }
    }
}
