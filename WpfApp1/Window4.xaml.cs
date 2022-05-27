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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            string name = title.Text.Trim();
            string desc = description.text.trim();
            int.price=price.int.trim();
            string.status=status.Text.Trim();
            if (title.Length < 5)
            {
                title.ToolTip = "минимальная длинна логина 5 символов";
                title.Background = Brushes.Red;
            }
            else if (description.Length < 5)
            {
                description.ToolTip = "минимальная длинна пароля 5 символов";
                description.Background = Brushes.Red;
            }
            else if (price.Length < 2)
            {
                price.ToolTip = "минимальная длинна пароля 5 символов";
                price.Background = Brushes.Red;
            }
            else if (status.Length < 5)
            {
                status.ToolTip = "минимальная длинна пароля 5 символов";
                status.Background = Brushes.Red;
            }
            else
            {
                
                db.users.change(user);
                db.SaveChanges();


            }


        }
    }
}
