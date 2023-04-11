using PC_klub.PC_klub22DataSetTableAdapters;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace PC_klub
{
    /// <summary>
    /// Логика взаимодействия для POLZOVATILY.xaml
    /// </summary>
    public partial class POLZOVATILY : Page
    {
        polzovatilyTableAdapter pol = new polzovatilyTableAdapter();
        klass_polzovatelyaTableAdapter kl = new klass_polzovatelyaTableAdapter();

        public POLZOVATILY()
        {
            InitializeComponent();
            dt1.ItemsSource = pol.GetData();
            Combo.ItemsSource = kl.GetData();
            Combo.DisplayMemberPath = "opisaniye";
            Combo.SelectedValuePath = "klasp_id";
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dt1.SelectedItem != null)
            {
                object IDklass = (dt1.SelectedItem as DataRowView).Row[1];
                Combo.SelectedValue = Convert.ToInt32(IDklass);
                object selectedRow = (dt1.SelectedItem as DataRowView).Row[2];
                tb.Text = Convert.ToString(selectedRow);
                object LASTNAME = (dt1.SelectedItem as DataRowView).Row[3];
                tb1.Text = Convert.ToString(LASTNAME);
                object Phone = (dt1.SelectedItem as DataRowView).Row[4];
                tb2.Text = Convert.ToString(Phone);
                object email = (dt1.SelectedItem as DataRowView).Row[5];
                tb3.Text = Convert.ToString(email);
                object LOG = (dt1.SelectedItem as DataRowView).Row[6];
                tb4.Text = Convert.ToString(LOG);
                object PAROL = (dt1.SelectedItem as DataRowView).Row[7];
                tb5.Text = Convert.ToString(PAROL);




            }
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            string input = tb.Text;
            string input2 = tb1.Text;
            string input3 = tb2.Text;
            string input4 = tb3.Text;
            string input5 = tb4.Text;
            string input6 = tb5.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$")&&
                System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Zа-яА-Я]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input3, "^[0-9+]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z@.0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input5, "^[a-zA-Zа-яА-Я0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input6, "^[a-zA-Zа-яА-Я0-9]+$"))
            {
                pol.InsertQuery(Convert.ToInt32(Combo.SelectedValue), tb.Text, tb1.Text, tb2.Text, tb3.Text, tb4.Text, tb5.Text);
                dt1.ItemsSource = pol.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
            
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt1.SelectedItem as DataRowView).Row[0];
            pol.DeleteQuery(Convert.ToInt32(id));
            dt1.ItemsSource = pol.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                string input = tb.Text;
                string input2 = tb1.Text;
                string input3 = tb2.Text;
                string input4 = tb3.Text;
                string input5 = tb4.Text;
                string input6 = tb5.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Zа-яА-Я]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input3, "^[0-9+]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Z@.0-9]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input5, "^[a-zA-Zа-яА-Я0-9]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input6, "^[a-zA-Zа-яА-Я0-9]+$"))
                {
                    object id = (dt1.SelectedItem as DataRowView).Row[0];
                    pol.UpdateQuery(Convert.ToInt32(Combo.SelectedValue), tb.Text, tb1.Text, tb2.Text, tb3.Text, tb4.Text, tb5.Text, Convert.ToInt32(id));
                    dt1.ItemsSource = pol.GetData();
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
