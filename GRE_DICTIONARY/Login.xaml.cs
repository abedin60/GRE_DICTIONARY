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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_click(object sender, RoutedEventArgs e)
        {
            string s = text_name.Text;
            string p = passwordBox.Password;
            if(s=="authority" && p=="abedin")
            {
                Modify mo = new Modify();
                mo.Show();
                this.Close();
            }
            else
            {
                lbl_msg.Content = "Invalid User Name or password. Try Again...";
                text_name.Text = "";
                passwordBox.Password = "";
            }
        }

        private void cancle_btn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void login_back_btn_click(object sender, RoutedEventArgs e)
        {
            Main min = new Main();
            min.Show();
            this.Close();
        }
    }
}
