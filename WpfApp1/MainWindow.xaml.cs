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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        applicatiooncontext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new applicatiooncontext();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string login = login.text.Trim();
            string password = password.text.Trim();

            if (login.Length < 5)
            {
                login.ToolTip = "поле введено некоректно";
                    login.Background = Brushes.Red;
            }else if (password.Length < 5)
            {
                password.ToolTip = "поле введено некоректно";
                password.Background = Brushes.Red;
            }
            else
            {
                login.ToolTip = "";
                login.Background = Brushes.Transparent;
                password.ToolTip = "";
                password.Background = Brushes.Transparent;
                MessageBox.Show("все хорошо");
                users user=new users(login,password)
                
                
                db.users.Find(user);
                

            }




        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Owner = this;
            window1.Show();
        }
    }
}
