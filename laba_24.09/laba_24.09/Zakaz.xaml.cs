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

namespace laba_24._09
{
    /// <summary>
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Postavka_window postavka_Window = new Postavka_window();
            postavka_Window.Show();
            this.Close();
        }

        private void add_zakaz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ добавлен!", "Успешно!");
        }
    }
}
