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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_cng_click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void use_btn_click(object sender, RoutedEventArgs e)
        {
           Dictionary di = new Dictionary();
            di.Show();
            this.Close();
        }

        private void about_btn_click(object sender, RoutedEventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
            this.Close();
        }
    }
}
