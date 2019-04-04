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

namespace baitappp
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

        private void Tong_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double s = 1;
            for(int i =2;i<=n;i++)
            {
                s += Math.Sqrt(i);
            }
            txtKQ.Text = s.ToString();
        }

        private void TONG_Click_1(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtsoN.Text);
            double S = 0;
            int x = 2;
            for (int i = 1; i <= n; i++)
            {
                S += Math.Pow(x, i);
            }
            txtkq.Text = S.ToString();
        }

    }
}
