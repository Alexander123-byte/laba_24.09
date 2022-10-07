using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
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
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class Window_admin : Window
    {
        static int chet_sec = 0;
        static int chet_min = 0;

        System.Timers.Timer timer = new System.Timers.Timer();
        public Window_admin()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Elapsed += OnTimerElapsed;
            timer.Start();
        }

        private void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            chet_sec++;
            seconds.Dispatcher.Invoke(() =>
            {
                seconds.Text = "Секунды: " + chet_sec;
            });

            if (chet_sec == 60)
            {
                chet_sec = 0;
                chet_min++;
                minutes.Dispatcher.Invoke(() =>
                {
                    minutes.Text = "Минут: " + chet_min;
                });
            }

            if (chet_min == 5 && chet_sec == 0)
                MessageBox.Show("Сеанс скоро завершится", "Предупреждение");
            if (chet_min == 10 && chet_sec == 0)
            {
                MessageBox.Show("Сеанс завершился", "Все");
                timer.Stop();
                chet_sec = 0;
                chet_min = 0;
                Application.Current.Dispatcher.Invoke(() =>
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            timer.Stop();
            chet_sec = 0;
            chet_min = 0;
        }
    }
}
