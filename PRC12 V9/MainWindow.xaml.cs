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
using System.Windows.Threading;

namespace PRC12_V9
{
    //Реализовать расчет задачи: Дана площадь S круга.Найти его диаметр D и длину L окружности,ограничивающей этот круг, учитывая, что L = PI * D, S = PI * D2/ 4.В качествезначения PI использовать 3.14.
    //С начала суток прошло N секунд (N — целое). Найти количество полных часов,прошедших сначала суток.
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д.А ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            int S, D, L, pi;
            if (square.Text != "")
            {
                S = Convert.ToInt32(square.Text);
                pi = Convert.ToInt32(3.14);
                D = Convert.ToInt32(Math.Sqrt(4 * S / pi));
                L = Convert.ToInt32(pi * D);
                diameter.Text = Convert.ToString(D);
                length.Text = Convert.ToString(L);
            }
            else MessageBox.Show("Не корректный ввод");
        }

        private void FindKol_Click(object sender, RoutedEventArgs e)
        {
            int i, F;
            if (kolSecond.Text != "")
            {
                i = Convert.ToInt32(kolSecond.Text);
                F = Convert.ToInt32(i / 3600);
                findKolHour.Text = Convert.ToString(F);
            }
            else MessageBox.Show("Не корректный ввод");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            square.Clear();
            diameter.Clear();
            length.Clear();
            kolSecond.Clear();
            findKolHour.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime now = DateTime.Now;
            Data.Text = now.ToString("D");

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
