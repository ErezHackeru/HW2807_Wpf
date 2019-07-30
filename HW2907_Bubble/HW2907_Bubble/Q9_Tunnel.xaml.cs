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
using System.Windows.Shapes;

namespace HW2907_Bubble
{
    /// <summary>
    /// Interaction logic for Q9_Tunnel.xaml
    /// </summary>
    public partial class Q9_Tunnel : Window
    {
        public Q9_Tunnel()
        {
            InitializeComponent();
        }

        private void OuterBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            lbl1.Content += "Outer Button; ";
        }

        private void InnerBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            lbl1.Content += "Inner Button; ";
        }
    }
}
