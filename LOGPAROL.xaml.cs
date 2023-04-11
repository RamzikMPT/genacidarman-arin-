using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using PC_klub.PC_klub22DataSetTableAdapters;

namespace PC_klub
{
    /// <summary>
    /// Логика взаимодействия для LOGPAROL.xaml
    /// </summary>
    public partial class LOGPAROL : Page
        
    {
        sotrudnikiTableAdapter sot = new sotrudnikiTableAdapter();
        roliTableAdapter rol = new roliTableAdapter();
        public LOGPAROL()
        {
            InitializeComponent();
            dt1.ItemsSource = sot.GetData();
            Combo.ItemsSource = rol.GetData();
            Combo.DisplayMemberPath = "opisaniye_roli";
            Combo.SelectedValuePath = "ROLE_id";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                object selectedRow = (dt1.SelectedItem as DataRowView).Row[1];
                tbx.Text = Convert.ToString(selectedRow);
                object LASTNAME = (dt1.SelectedItem as DataRowView).Row[2];
                tbx_Copy.Text = Convert.ToString(LASTNAME);
                object LOG = (dt1.SelectedItem as DataRowView).Row[3];
                tbx_Copy1.Text = Convert.ToString(LOG);
                object PAROL = (dt1.SelectedItem as DataRowView).Row[4];
                tbx_Copy2.Text = Convert.ToString(PAROL);
                object IDROL = (dt1.SelectedItem as DataRowView).Row[5];
                Combo.SelectedValue = Convert.ToInt32(IDROL);

            }
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            string input = tbx.Text;
            string input2 = tbx_Copy.Text;
            string input3 = tbx_Copy1.Text;
            string input4 = tbx_Copy2.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$")&&
                System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Zа-яА-Я]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input3, "^[a-zA-Zа-яА-Я0-9]+$") &&
                System.Text.RegularExpressions.Regex.IsMatch(input4, "^[a-zA-Zа-яА-Я0-9]+$") )
            {
                sot.InsertQuery(tbx.Text, tbx_Copy.Text, tbx_Copy1.Text, tbx_Copy2.Text, Convert.ToInt32(Combo.SelectedValue));
                dt1.ItemsSource = sot.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
           
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt1.SelectedItem as DataRowView).Row[0];
            sot.DeleteQuery(Convert.ToInt32(id));
            dt1.ItemsSource = sot.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                object id = (dt1.SelectedItem as DataRowView).Row[0];
                sot.UpdateQuery(tbx.Text, tbx_Copy.Text, tbx_Copy1.Text, tbx_Copy2.Text, Convert.ToInt32(Combo.SelectedValue),Convert.ToInt32(id));
                dt1.ItemsSource = sot.GetData();

            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }

        

        //private void Return_Click(object sender, RoutedEventArgs e)
        //{
            //(Application.Current.MainWindow as LOGPAROL).fr.Content = new Admin();
        //}
    }
}
