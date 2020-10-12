using BVG.TicketApp.Wpf.ViewModel;
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

namespace BVG.TicketApp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new TicketViewModel();
        }

        private void OrderTicket(object sender, RoutedEventArgs e)
        {
            Button TicketButton = (Button)sender;
            string ticketInfo = TicketButton.Content.ToString();
            OrderList.Items.Add(ticketInfo);
            PaymentList.Items.Add(ticketInfo);
            
            if (PriceList.Text == "")
            {
                string price = ticketInfo.Substring(ticketInfo.Length - 5, 4);
                PriceList.Text = $"{price}";
            }
            else
            {
                decimal newPrice = Convert.ToDecimal(PriceList.Text) + Convert.ToDecimal(ticketInfo.Substring(ticketInfo.Length - 5, 4));
                 PriceList.Text = $"{newPrice}";
            }     
        }

        private void InstantiatePayment(object sender, RoutedEventArgs e)
        {
           MoneyList.Visibility = Visibility.Visible;
           TicketList.Visibility = Visibility.Hidden;
            PaymentList.Visibility = Visibility.Visible;
            OrderList.Visibility = Visibility.Hidden; 
            Payment.Visibility = Visibility.Visible;

        }        
        private void MoneyButton(object sender, RoutedEventArgs e)
        {
            Button MoneyButton= (Button)sender;
            string paid = MoneyButton.Content.ToString();
            decimal coinThrow = + Convert.ToDecimal(paid.Substring(0,4));
            Payment.Items.Add(coinThrow + "");
            decimal paidTotal = Convert.ToDecimal(Paid.Text.Substring(0,4));

            decimal total = Convert.ToDecimal(PriceList.Text);

            if (paidTotal > total)
            {
                MessageBox.Show("Please Take your Receive");
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }

            if (Paid.Text == "")
            {
                string price = paid.Substring(0, 4);
                Paid.Text = $"{price}";
            }
            else
            {
                decimal newPrice = Convert.ToDecimal(Paid.Text) + Convert.ToDecimal(paid.Substring(0, 4));
                Paid.Text = $"{newPrice}";
            }
        }
    }
}
