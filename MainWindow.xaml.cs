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

namespace _184784GoodTimes
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

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtTimes.Text;
            int time = 0;
            int.TryParse(TextEntered, out time);

            int Victoria = time - 300;
            int Edmonton = time - 200;
            int Winnipeg = time - 100;
            int Toronto = time;
            int Halifax = time + 100;
            int StJohns = time + 130;

            if (Victoria % 100 > 59) Victoria = Victoria -60 + 100;
            if (Victoria <= 0)
            {
                Victoria += 2400;
            }
            if (Edmonton % 100 > 59)Edmonton = Edmonton -60 + 100;
            if (Edmonton <= 0)
            {
                Edmonton += 2400;
            }
            if (Winnipeg % 100 > 59)Winnipeg = Winnipeg -60 + 100;
            if (Winnipeg <= 0)
            {
                Winnipeg += 2400;
            }
            if (Toronto % 100 > 59)Toronto = Toronto -60 + 100;
            if (Toronto <= 0)
            {
                Toronto += 2400;
            }
            if (Halifax % 100 > 59)Halifax = Halifax -60 + 100;
            if (Halifax <= 0)
            {
                Halifax += 2400;
            }
            if (StJohns % 100 > 59)StJohns = StJohns -60 + 100;
            if (StJohns <= 0)
            {
                StJohns += 2400;
            }

            lblTimes.Content += time + " The time in Ottawa" + "\r" + "\n";
            lblTimes.Content += Victoria + " The time in Victoria" + "\r" + "\n";
            lblTimes.Content += Edmonton + " The time in Edmonton" + "\r" + "\n";
            lblTimes.Content += Winnipeg +" The time in Winnipeg" + "\r" + "\n";
            lblTimes.Content += Toronto +" The time in Toronto" + "\r" + "\n";
            lblTimes.Content += Halifax +" The time in Halifax" + "\r" + "\n";
            lblTimes.Content += StJohns +" The time in St. John's" + "\r" + "\n";
        }
    }
}
