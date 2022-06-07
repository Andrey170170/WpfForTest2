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
        }
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            this.StateString.Content = ((MenuItem)sender).Header.ToString();
        }
        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            this.StateString.Content = string.Empty;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MenuItem)sender).Header.ToString()?[1..]);
        }

        private void Solid_OnClick(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Background = new SolidColorBrush(Colors.Red);
        }

        private void Gradient_OnClick(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Background = new LinearGradientBrush(Colors.Red, Colors.GreenYellow,
                new Point(0, 0), new Point(1, 1));
        }
    }
}
