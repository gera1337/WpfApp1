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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        applicatiooncontext db;
        public Window1()
        {
            InitializeComponent();
            db = new applicatiooncontext();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            string login = login.text.Trim();
            string password = password.text.Trim();

            if (login.Length < 5)
            {
                login.ToolTip = "минимальная длинна логина 5 символов";
                login.Background = Brushes.Red;
            }
            else if (password.Length < 5)
            {
                password.ToolTip = "минимальная длинна пароля 5 символов";
                password.Background = Brushes.Red;
            }
            else
            {
                login.ToolTip = "";
                login.Background = Brushes.Transparent;
                password.ToolTip = "";
                password.Background = Brushes.Transparent;
                MessageBox.Show("все хорошо");
                users user = new users(login, password);

                db.users.Add(user);
                db.SaveChanges();


            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
