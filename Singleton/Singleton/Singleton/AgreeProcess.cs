using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Singleton
{
    internal class AgreeProcess
    {
        private static AgreeProcess instance;
        private string From;
        private string To;
        private int HowMuch;
        private AgreeProcess(string fromInformation, string toInformation, int howMuchInf)
        {
            this.From = fromInformation;
            this.To = toInformation;
            this.HowMuch = howMuchInf;
            Thread proc = new Thread(paymentLogicProcess);
            proc.Start();
           


        }

        public static AgreeProcess getInstance(string fromInf, string toInf, int costInf)
        {
            if (instance == null)
            {
                PayProcess PP = new PayProcess();
                PP.Visibility = Visibility.Visible;
                instance = new AgreeProcess(fromInf, toInf, costInf);
                
            }
                
            else
                MessageBox.Show("Оплата уже идет!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            return instance;
        }

        private void paymentLogicProcess()
        {
            Console.WriteLine("Логика оплаты");
            
            // Эммитация работы оплаты
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("i: " + i);
                Thread.Sleep(1000);
            }

            instance = null;
        }
    }
}
