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

namespace GRE_DICTIONARY
{
    /// <summary>
    /// Interaction logic for About_Us.xaml
    /// </summary>
    public partial class About_Us : Window
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void back_btn_click(object sender, RoutedEventArgs e)
        {
            Main min = new Main();
            min.Show();
            this.Close();
        }
    }
}
