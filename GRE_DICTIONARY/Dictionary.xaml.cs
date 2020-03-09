﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
    /// Interaction logic for Dictionary.xaml
    /// </summary>
    public partial class Dictionary : Window
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void cross_btn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void search_btn_click(object sender, RoutedEventArgs e)
        {
            string searchText = textBox.Text;
	        if(searchText!="")
	        {
                string con = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
		        SqlConnection sqlcon = new SqlConnection(con);
		        sqlcon.Open();

		        string sqlquery = "Select * from Table_3 where word='"+searchText+"'";
		        SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

		        SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
		        DataTable dt = new DataTable("Table_3");
		        data_adapter.Fill(dt);
		        dataGrid.ItemsSource = dt.DefaultView;
		        data_adapter.Update(dt);
		        sqlcon.Close();
	        }
	        else 
	        {
                string con = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
		        SqlConnection sqlcon = new SqlConnection(con);
		        sqlcon.Open();

		        string sqlquery = "Select * from Table_3";
		        SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

		        SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
		        DataTable dt = new DataTable("Table_3");
		        data_adapter.Fill(dt);
		        dataGrid.ItemsSource = dt.DefaultView;
		        data_adapter.Update(dt);
		        sqlcon.Close();
	        }

	    }

        private void clearDataGrid()
        {
            string con = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery = "Select * from Table_3 where word=''";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

            SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable("Table_3");
            data_adapter.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            data_adapter.Update(dt);
            sqlcon.Close();
        }

	private void dictionary_loaded(object sender, RoutedEventArgs e)
	{
            string con = @"Data Source=.;Initial Catalog=GRE_DICTIONARY_db;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(con);
            sqlcon.Open();

            string sqlquery = "Select * from Table_3";
            SqlCommand sqlcmd = new SqlCommand(sqlquery, sqlcon);

            SqlDataAdapter data_adapter = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable("Table_3");
            data_adapter.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            data_adapter.Update(dt);
            sqlcon.Close();
        }
    }
}
