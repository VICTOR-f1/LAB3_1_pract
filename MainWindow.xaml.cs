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

namespace LAB3
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            this.Background = brush;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработал фарносов виктор");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "МЕНЮ";
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "";

        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "изменять цвет фона окна";

        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "";

        }

        private void MenuItem_MouseEnter_1(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "получить информацию о разработчике";

        }

        private void MenuItem_MouseLeave_1(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "";

        }

        private void MenuItem_MouseEnter_2(object sender, MouseEventArgs e)
        {
            textBlock1.Text = "закрыть окно";

        }

        private void MenuItem_MouseLeave_2(object sender, MouseEventArgs e)
        {

        }
    }
}
