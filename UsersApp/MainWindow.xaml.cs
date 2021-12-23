using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            // start - обработчик событий (валидация)

            string login = textBoxLogin.Text.Trim(); // .Trim() удаление пробелов
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower(); // нижний регистр

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле имеет меньше 5 символов!";
                textBoxLogin.Background = Brushes.DarkRed;  // цвет поля при ошибке
            }
            else if (pass.Length < 6)
            {
                passBox.ToolTip = "Пароль должен содержать не менее 6 символов!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass_2 != pass)
            {
                passBox_2.ToolTip = "Пароль не совпадает!";
                passBox_2.Background = Brushes.DarkRed;  // цвет поля при ошибке
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Поле введено не корректно!";
                textBoxEmail.Background = Brushes.DarkRed;  // цвет поля при ошибке
            }
            else // отменяет все предупреждения
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Все введено корректно."); // всплывающее окно
            }

            // end - обработчик событий
        }
    }
}
