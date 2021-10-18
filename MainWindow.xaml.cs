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

namespace GridPanel_2
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

        private void MsgBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Witaj, świecie!");
        }

        private void Button6_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            button6.Content = data.ToString("T");
        }

        private void button6_MouseLeave(object sender, MouseEventArgs e)
        {
            button6.Content = "Czas";
        }
        private void ButtonZ_Click(object sender, RoutedEventArgs e)
        {
            buttonTPZ.Content = "Tekst Po Zmianie";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonTPZ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btna_Click(object sender, RoutedEventArgs e)
        {
            btnat.Content = "Aktywny";
            btnat.IsEnabled = true;
            btna.Content = "Aktywowano";
            btna.IsEnabled = false;
        }
    }
}
