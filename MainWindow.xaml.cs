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

namespace WashingHouseChetvernyaDemo
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

        private void ButtonEnterAuth_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBLogAuth.Text) || string.IsNullOrEmpty(TBPasswordAuth.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            using (var db = new WashingHouseChetvernyaEntities1())
            {
                var user = db.Staff
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == TBLogAuth.Text && u.Password == TBPasswordAuth.Password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }
                MessageBox.Show("Пользователь успешно найден!");

                switch (user.StaffRole)
                {
                    case 1:
                        Window EmployeeWindow = new EmloyeeWindow();
                        EmployeeWindow.Show();
                        break;

                    case 2:
                        Window AdminWindow = new AdminWindow();
                        AdminWindow.Show();
                        break;
                }
                Close();
            }
        }
    }
}
