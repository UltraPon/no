using practice1.practi1DataSet1TableAdapters;
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
using practice1.practi1DataSetTableAdapters;
using ticketsTableAdapter = practice1.practi1DataSet1TableAdapters.ticketsTableAdapter;

namespace practice1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        ticketsTableAdapter ticket = new ticketsTableAdapter();
        public Page2()
        {
            InitializeComponent();
            tick1.ItemsSource = ticket.GetData();
        }
    }
}
