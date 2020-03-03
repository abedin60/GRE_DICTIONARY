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
using System.Data;
using System.Data.SqlClient;

namespace GRE_DICTIONARY
{
    /// <summary>
    /// Interaction logic for Modify.xaml
    /// </summary>
    public partial class Modify : Window
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void delete_btn_click(object sender, RoutedEventArgs e)
        {
            string word = word_txt.Text;

            string connectionstring = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "delete from Table_3 where word= @a";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = word;
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows > 0)
                MessageBox.Show("Information Has Deleted.");
            word_txt.Text = "";
        }
           

        private void insert_btn_click(object sender, RoutedEventArgs e)
        {
            string serial = serial_txt.Text;
            string word = word_txt.Text;
            string engmeaning = eng_meaning.Text;
            string prtsofspeech = prtsof_speech.Text;
            string connectionstring = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into Table_3(Serial_no, Word, English_meaning, Parts_of_speech) values(@a,@b,@c,@d)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.Int).Value = serial;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = word;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = engmeaning;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = prtsofspeech;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Word is added");
            sqlcon.Close();
            serial_txt.Text = "";
            word_txt.Text = "";
            eng_meaning.Text = "";
            prtsof_speech.Text = "";

        }

        private void cross_btn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
