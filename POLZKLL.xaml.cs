using PC_klub.PC_klub22DataSetTableAdapters;
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


namespace PC_klub
{
    /// <summary>
    /// Логика взаимодействия для POLZKLL.xaml
    /// </summary>
    public partial class POLZKLL : Page
    {
        klass_polzovatelyaTableAdapter klass = new klass_polzovatelyaTableAdapter();
        public POLZKLL()
        {
            InitializeComponent();
            dt1.ItemsSource = klass.GetData();
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                object selectedRow = (dt1.SelectedItem as DataRowView).Row[1];
                tbx.Text = Convert.ToString(selectedRow);
            }
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            
            string input = tbx.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$"))
            {
                klass.InsertQuery(tbx.Text);
                dt1.ItemsSource = klass.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt1.SelectedItem as DataRowView).Row[0];
            klass.DeleteQuery(Convert.ToInt32(id));
            dt1.ItemsSource = klass.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                string input = tbx.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$"))
                {
                    object id = (dt1.SelectedItem as DataRowView).Row[0];
                    klass.UpdateQuery(tbx.Text, Convert.ToInt32(id));
                    dt1.ItemsSource = klass.GetData();
                }
                else
                {
                    MessageBox.Show("неправильный ввод");
                }
                

            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }
    }
}
