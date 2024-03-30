using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Singleton
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

        public void Pay(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Оплата");
            try
            {
                
                AgreeProcess agreeProcess = AgreeProcess.getInstance(
                From.Text.ToString(),
                To.Text.ToString(),
                Convert.ToInt32(HowMuch.Text.ToString()));
                

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка данных", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

    }
}
