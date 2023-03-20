using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
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
using practice1.practi1DataSetTableAdapters;

namespace practice1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        clientTableAdapter client = new clientTableAdapter();
        public Page1()
        {
            InitializeComponent();
            cl1.ItemsSource = client.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client.InsertQuery(imya.Text, family.Text, patronymic.Text);
            cl1.ItemsSource = client.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            int id = (int)(cl1.SelectedItem as DataRowView).Row[0];
            client.DeleteQuery(id);
            cl1.ItemsSource = client.GetData();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (cl1.SelectedItem != null)
            {
                var item = cl1.SelectedItem as DataRowView;
                client.UpdateQuery(imya.Text, family.Text, patronymic.Text, (int)item.Row[0]);
                cl1.ItemsSource = client.GetData();
            }
        }
        private void cl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cl1.SelectedItem != null)
            {
                var item = cl1.SelectedItem as DataRowView;
                imya.Text = Convert.ToString(item.Row[1]);
                family.Text = Convert.ToString(item.Row[2]);
                patronymic.Text = Convert.ToString(item.Row[3]);
            }
        }
    }
}