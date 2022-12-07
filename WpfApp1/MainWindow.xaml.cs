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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void v1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кузнецов Алексей ИСП-31. Задание:  Создать базовый класс Pair (пара целых чисел). Создать необходимые методы и \r\nсвойства. Определить методы с операциями проверки на равенство и \r\nперемножения полей. Реализовать операцию вычитания пар по формуле (а, b) - (с, \r\nd) = (а - c, b - d). Создать перегруженный метод для вычитания трех пар чисел.\r\n");
        }

        private void Close1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кузнецов Алексей ИСП-31. Задание:  Создать базовый класс Pair (пара целых чисел). Создать необходимые методы и \r\nсвойства. Определить методы с операциями проверки на равенство и \r\nперемножения полей. Реализовать операцию вычитания пар по формуле (а, b) - (с, \r\nd) = (а - c, b - d). Создать перегруженный метод для вычитания трех пар чисел.\r\n");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void subtraction2(object sender, RoutedEventArgs e)
        {
            try
            {
                int fpfz = Convert.ToInt32(v1.Text);
                int fpsz = Convert.ToInt32(v2.Text);
                int spfz = Convert.ToInt32(v3.Text);
                int spsz = Convert.ToInt32(v4.Text);
                Pair pair1 = new Pair(fpfz, fpsz);
                Pair pair2 = new Pair(spfz, spsz);
                Pair pair = pair1.Substraction(pair2);
                result1.Text = $"{pair.First}";
                result2.Text = $"{pair.Second}";
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void subtraction3(object sender, RoutedEventArgs e)
        {
            try
            {
                int fpfz = Convert.ToInt32(v1.Text);
                int fpsz = Convert.ToInt32(v2.Text);
                int spfz = Convert.ToInt32(v3.Text);
                int spsz = Convert.ToInt32(v4.Text);
                int thirdfz = Convert.ToInt32(v5.Text);
                int thirdsz = Convert.ToInt32(v6.Text);
                Pair pair1 = new Pair(fpfz, fpsz);
                Pair pair2 = new Pair(spfz, spsz);
                Pair pair3 = new Pair(thirdfz, thirdsz);
                Pair pair = pair1.Substraction(pair2, pair3);
                result1.Text = $"{pair.First}";
                result2.Text = $"{pair.Second}";
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }
        }

        private void Compare(object sender, RoutedEventArgs e)
        {
            if (result1.Text == result2.Text)
            {
                MessageBox.Show("Пары равны");
            }
            else
            {
                MessageBox.Show("Пары неравны");
            }
        }
    }
}
