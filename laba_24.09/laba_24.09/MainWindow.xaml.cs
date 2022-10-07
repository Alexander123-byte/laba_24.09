using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace laba_24._09
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
        Window_admin window_Admin = new Window_admin();
        Postavka_window postavka_Window = new Postavka_window();
        Kassir_window kassir_Window = new Kassir_window();

        private void close_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (textbox_login.Text == "admin" && textbox_password.Text == "admin")
            {
                MessageBox.Show("Вы вошли за админа!");
                window_Admin.Show();
                this.Close();
            }
            if (textbox_login.Text == "postavka" && textbox_password.Text == "post")
            {
                MessageBox.Show("Вы вошли за поставщика!");
                postavka_Window.Show();
                this.Close();
            }
            if (textbox_login.Text == "kassir" && textbox_password.Text == "kassir")
            {
                MessageBox.Show("Вы вошли за кассира!");
                kassir_Window.Show();
                this.Close();
            }
            else if (textbox_login.Text.Length < 1 || textbox_password.Text.Length < 1)
                MessageBox.Show("Заполните все поля!");
            else if (textbox_login.Text != "admin" && textbox_login.Text != "postavka" && textbox_login.Text != "kassir"
                && textbox_password.Text != "admin" && textbox_password.Text != "post" && textbox_password.Text != "kassir")
                MessageBox.Show("Проверьте правильность введенных данных!");
        }

        private void help_enter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вход за администратора: admin - admin\nВход за поставщика: postavka - post\nВход за кассира: kassir - kassir");
        }
    }
}