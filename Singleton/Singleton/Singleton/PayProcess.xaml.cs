using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Shapes;

namespace Singleton
{
    /// <summary>
    /// Логика взаимодействия для PayProcess.xaml
    /// </summary>
    public partial class PayProcess : Window
    {
        public PayProcess()
        {
            InitializeComponent();
            
            Thread effect = new Thread(CircleEffects);
            effect.Start();
            
        }

        private void CircleEffects()
        {
            Console.WriteLine(this.Visibility);
            List<int> matg = new List<int>()
            {
                50, 0
            };
            int index = 0;
            int count = 0;
            while (index != 20)
            {
                Console.WriteLine("work");
                this.Dispatcher.BeginInvoke(new Action(() => circle_1.Margin= new Thickness(25, 0, 0, matg[count])));
                Thread.Sleep(300);
                this.Dispatcher.BeginInvoke(new Action(() => circle_2.Margin= new Thickness(25, 0, 0, matg[count])));
                Thread.Sleep(300);
                this.Dispatcher.BeginInvoke(new Action(() => circle_3.Margin= new Thickness(25, 0, 0, matg[count])));
                Thread.Sleep(300);
                index++;
                if (count == 0)
                    count = 1;
                else
                    count = 0;
            }
            CollapceShow();
            
        }

        public void CollapceShow()
        {
            this.Dispatcher.BeginInvoke(new Action(() => this.Visibility = Visibility.Collapsed));
            MessageBox.Show("Операция завершена!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            
        }
    }
}
