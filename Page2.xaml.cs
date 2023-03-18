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
using System.Data;
using practice1.practi1DataSetTableAdapters;

namespace practice1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        ticketsTableAdapter ticket = new ticketsTableAdapter();
        clientTableAdapter client = new clientTableAdapter();
        public Page2()
        {
            InitializeComponent();
            tick1.ItemsSource = ticket.GetData();
            boxik.ItemsSource = client.GetData();
            boxik.DisplayMemberPath = "client_name";
            boxik.SelectedValuePath = "id";
        }
        private void vvestidannie_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)boxik.SelectedValue;
            ticket.InsertQuery1(Convert.ToInt32(price.Text), Convert.ToInt32(mesto.Text), Convert.ToInt32(ryad.Text), id);
            tick1.ItemsSource = ticket.GetData();
        }

        private void udalitdannie_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(tick1.SelectedItem as DataRowView).Row[0];
            ticket.DeleteQuery(id);
            tick1.ItemsSource = ticket.GetData();
        }
    }
}