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
    /// Логика взаимодействия для kss.xaml
    /// </summary>
    public partial class kss : Page
    {
        history_payTableAdapter hs = new history_payTableAdapter();
        tip_oplatiTableAdapter t = new tip_oplatiTableAdapter();
        tarifiTableAdapter tr = new tarifiTableAdapter();
        polzovatilyTableAdapter pol = new polzovatilyTableAdapter();
        sotrudnikiTableAdapter sot = new sotrudnikiTableAdapter();
        public kss()
        {
            InitializeComponent();
            gf.ItemsSource = hs.GetData();
            cb1.ItemsSource = t.GetData();
            cb2.ItemsSource = tr.GetData();
            cb3.ItemsSource = pol.GetData();
            cb4.ItemsSource = sot.GetData();
            cb1.DisplayMemberPath = "opisaniye";
            cb1.SelectedValuePath = "tipoplati_id";
            cb2.DisplayMemberPath = "name";
            cb2.SelectedValuePath = "tarif_id";
            cb3.DisplayMemberPath = "name";
            cb3.SelectedValuePath = "polzovatel_id";
            cb4.DisplayMemberPath = "Name";
            cb4.SelectedValuePath = "Sotrudnik_id";


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedRow = (gf.SelectedItem as DataRowView).Row[1];
            tb1.Text = Convert.ToString(selectedRow);
            object selectedRo = (gf.SelectedItem as DataRowView).Row[2];
            tb2.Text = Convert.ToString(selectedRo);
            object id = (gf.SelectedItem as DataRowView).Row[3];
            cb1.SelectedValue = Convert.ToInt32(id);
            object idp = (gf.SelectedItem as DataRowView).Row[4];
            cb2.SelectedValue = Convert.ToInt32(idp);
            object idps= (gf.SelectedItem as DataRowView).Row[5];
            cb3.SelectedValue = Convert.ToInt32(idps);
            object IDkl = (gf.SelectedItem as DataRowView).Row[6];
            cb4.SelectedValue = Convert.ToInt32(IDkl);
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            
            string input = tb1.Text;
            string input2 = tb2.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9.]+$")&&
                System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9]+$") )
            {
                hs.InsertQuery(tb1.Text, tb2.Text, Convert.ToInt32(cb1.SelectedValue), Convert.ToInt32(cb2.SelectedValue), Convert.ToInt32(cb3.SelectedValue), Convert.ToInt32(cb4.SelectedValue));
                gf.ItemsSource = hs.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (gf.SelectedItem as DataRowView).Row[0];
            hs.DeleteQuery(Convert.ToInt32(id));
            gf.ItemsSource = hs.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (gf.SelectedItem != null)
            {
                string input = tb1.Text;
                string input2 = tb2.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9.]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(input2, "^[0-9]+$"))
                {
                    object id = (gf.SelectedItem as DataRowView).Row[0];
                    hs.UpdateQuery(tb1.Text, tb2.Text, Convert.ToInt32(cb1.SelectedValue), Convert.ToInt32(cb2.SelectedValue), Convert.ToInt32(cb3.SelectedValue), Convert.ToInt32(cb3.SelectedValue), Convert.ToInt32(id));
                    gf.ItemsSource = hs.GetData();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Kassir).hh.Content = new Tipoplati();
        }

        private void TARIF_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Kassir).hh.Content = new TARIFKAS();
        }
    }
}
