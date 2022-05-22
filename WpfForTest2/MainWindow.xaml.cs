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

namespace WpfForTest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var styles = new List<string> { "Solid", "Gradient" };
            styleList.SelectionChanged += ThemeChanged;
            styleList.ItemsSource = styles;
            styleList.SelectedItem = "Solid";
            styleList.MouseEnter += StylesSolid_MouseEnter;
        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {
            string? style = styleList.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary? resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Каталог товаров");
        }
        private void AboutCompany_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Медицинские статьи");
        }
        private void OurWorks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Об аптеке");
        }
        private void FindUs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Как найти нас ");
        }

        private void Styles_MouseEnter(object sender, MouseEventArgs e)
        {
            StateString.Text = "Стили приложения";
        }
        private void StylesSolid_MouseEnter(object sender, MouseEventArgs e)
        {
            StateString.Text = "Варианты заливки";
        }
        private void Links_MouseEnter(object sender, MouseEventArgs e)
        {
            StateString.Text = "Сслыки";
        }
    }
}
