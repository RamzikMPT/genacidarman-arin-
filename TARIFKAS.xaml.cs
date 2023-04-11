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
    /// Логика взаимодействия для TARIFKAS.xaml
    /// </summary>
    public partial class TARIFKAS : Page
    {
        tarifiTableAdapter tar = new tarifiTableAdapter();
        zalTableAdapter z = new zalTableAdapter();

        public TARIFKAS()
        {
            InitializeComponent();
            hh.ItemsSource = tar.GetData();
            cb.ItemsSource = z.GetData();
            cb.DisplayMemberPath = "nazvaniya_zala";
            cb.SelectedValuePath = "zali_id";

        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {

            string input = tb1.Text;
            string input2 = tb2.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я+]+$")&& System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9]+$"))
            {
                tar.InsertQuery(tb1.Text, tb2.Text, Convert.ToInt32(cb.SelectedValue));
                hh.ItemsSource = tar.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }


        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (hh.SelectedItem as DataRowView).Row[0];
            tar.DeleteQuery(Convert.ToInt32(id));
            hh.ItemsSource = tar.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (hh.SelectedItem != null)
            {
                string input = tb1.Text;
                string input2 = tb2.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я+]+$") && System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9]+$"))
                {
                    object id = (hh.SelectedItem as DataRowView).Row[0];
                    tar.UpdateQuery(tb1.Text,tb2.Text, Convert.ToInt32(cb.SelectedValue), Convert.ToInt32(id));
                    hh.ItemsSource = tar.GetData();
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

        private void hh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (hh.SelectedItem != null)
            {
                object selectedRow = (hh.SelectedItem as DataRowView).Row[1];
                tb1.Text = Convert.ToString(selectedRow);
                object selectedRo = (hh.SelectedItem as DataRowView).Row[2];
                tb2.Text = Convert.ToString(selectedRo);
                object id = (hh.SelectedItem as DataRowView).Row[3];
                cb.SelectedValue = Convert.ToInt32(id);

            }
        }
    }
}
