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

        AppContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext(); // ссылка на класс AppContext

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            // 1.start - обработчик событий
            
            // получение данных от пользователя

            string login = textBoxLogin.Text.Trim(); // .Trim() удаление пробелов
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower(); // нижний регистр

            // проверяем значения на корректность

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

                //1. end 


                //2.start - работа с БД

                User user = new User(login, email, pass); // создаем объект на основе модели

                db.Users.Add(user); // добавляет запись в бд
                db.SaveChanges(); // сохранение в бд

                // 3. Переход на окно авторизации после регистрации
                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                this.Hide();
            }
        }

        // 3. переключение на окно авторизации из окна регистрации
        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }
    }
}
