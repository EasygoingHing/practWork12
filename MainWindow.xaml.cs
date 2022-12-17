using System;
using System.Windows;
using System.Windows.Threading;
using Крутолапов_пр12;

namespace WpfApp12
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

        private void ButtonСonclusion_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbNumber.Text, out int value) && value.ToString().Length == 3)
            {
                tbNumber.Clear();
                tbNumber.Focus();
                tbResult1.Text = Class1.ReplacingNumbers(value);
            }
            else
            {
                MessageBox.Show("Данные введены некорректно или отсутствуют");
            }
        }

        private void ButtonSP_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbA.Text, out int side) && side > 0)
            {
                tbA.Clear();
                tbA.Focus();
                tbResult.Text = Class1.SquareAndPerimetr(side);
            }
            else
            {
                MessageBox.Show("Данные введены некорректно или отсутствуют");
            }
        }

        DispatcherTimer timer;//описываем таймер

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            data.Text = d.ToString("dd.MM.yyyy");
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Крутолапов Валерий ИСП-31");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
