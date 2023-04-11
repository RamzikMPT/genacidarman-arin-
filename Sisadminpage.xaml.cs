using System;
using System.Collections.Generic;
using System.Data;
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
using PC_klub.PC_klub2DataSetTableAdapters;

namespace PC_klub
{
    /// <summary>
    /// Логика взаимодействия для Sisadminpage.xaml
    /// </summary>
    public partial class Sisadminpage : Page
    {
        compiTableAdapter pc = new compiTableAdapter();
        public Sisadminpage()
        {
            InitializeComponent();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            pc.InsertQuery(tb.Text, tb1.Text, tb2.Text);
            dt1.ItemsSource = pc.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt1.SelectedItem as DataRowView).Row[0];
            pc.DeleteQuery(Convert.ToInt32(id));
            dt1.ItemsSource = pc.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                object id = (dt1.SelectedItem as DataRowView).Row[0];
                pc.UpdateQuery(tb.Text, tb1.Text, tb2.Text);
                dt1.ItemsSource = pc.GetData();

            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }
    }
}
