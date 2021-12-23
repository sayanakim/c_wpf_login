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
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            // 1.start - обработчик событий (валидация)
            
            // получение данных от пользователя 

            string login = textBoxLogin.Text.Trim(); // .Trim() удаление пробелов
            string pass = passBox.Password.Trim();

            // проверка на корректность 

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
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

                // 1. end

                // 2. запрос в бд о пользователе

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.Where(user => user.Login == login && user.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Все хорошо!");

                    // переход на окно кабинета при успешной авторизации
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Нет!");

                // 2. end
            }
        }

        // 3. переключение на окно регистрации из окна авторизации
        private void Button_Window_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
