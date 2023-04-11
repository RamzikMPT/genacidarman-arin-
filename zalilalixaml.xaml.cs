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
using PC_klub.PC_klub22DataSetTableAdapters;

namespace PC_klub
{
    /// <summary>
    /// Логика взаимодействия для zalilalixaml.xaml
    /// </summary>
    public partial class zalilalixaml : Page
    {
        zalTableAdapter zal = new zalTableAdapter();

        public zalilalixaml()
        {
            InitializeComponent();
            dt5.ItemsSource = zal.GetData();
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {

            string input = tb33.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я+]+$"))
            {
                zal.InsertQuery(tb33.Text);
                dt5.ItemsSource = zal.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }


        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt5.SelectedItem as DataRowView).Row[0];
            zal.DeleteQuery(Convert.ToInt32(id));
            dt5.ItemsSource = zal.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt5.SelectedItem != null)
            {
                string input = tb33.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я+]+$"))
                {
                    object id = (dt5.SelectedItem as DataRowView).Row[0];
                    zal.UpdateQuery(tb33.Text, Convert.ToInt32(id));
                    dt5.ItemsSource = zal.GetData();
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

        private void dt5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (dt5.SelectedItem != null)
            {
                object selectedRow = (dt5.SelectedItem as DataRowView).Row[1];
                tb33.Text = Convert.ToString(selectedRow);

            }
        }
    }
}
