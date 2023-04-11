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
    /// Логика взаимодействия для Tipoplati.xaml
    /// </summary>
    public partial class Tipoplati : Page
    {
        tip_oplatiTableAdapter tip = new tip_oplatiTableAdapter();
        public Tipoplati()
        {
            InitializeComponent();
            DataGrid.ItemsSource = tip.GetData();
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            
            string input = tb.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$"))
            {
                tip.InsertQuery(tb.Text);
                DataGrid.ItemsSource = tip.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (DataGrid.SelectedItem as DataRowView).Row[0];
            tip.DeleteQuery(Convert.ToInt32(id));
            DataGrid.ItemsSource = tip.GetData();
            
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                string input = tb.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$"))
                {
                     object id = (DataGrid.SelectedItem as DataRowView).Row[0];
                    tip.UpdateQuery(tb.Text, Convert.ToInt32(id));
                    DataGrid.ItemsSource = tip.GetData();

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

             
        

        private void IMPORT_Click(object sender, RoutedEventArgs e)
        {
            List<JASON2> forImport = DEER.DeserializeObject<List<JASON2>>();
            foreach (var item in forImport)
            {
                tip.InsertQuery(item.opisaniye);

            }
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = tip.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGrid.SelectedItem != null)
            {
                object selectedRow = (DataGrid.SelectedItem as DataRowView).Row[1];
                tb.Text = Convert.ToString(selectedRow);
                //DataGrid.ItemsSource = tip.GetData();
            }
        }
    }
}
