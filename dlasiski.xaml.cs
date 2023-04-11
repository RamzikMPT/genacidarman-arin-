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
    /// Логика взаимодействия для dlasiski.xaml
    /// </summary>
    public partial class dlasiski : Page
    {
        compiTableAdapter pc = new compiTableAdapter();
        public dlasiski()
        {
            InitializeComponent();
            dt1.ItemsSource = pc.GetData();
        }
        

        private void dob_Click(object sender, RoutedEventArgs e)
        {
           
            string input = tb.Text;
            string input1 = tb1.Text;
            string input2 = tb2.Text;



            if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$")&&
               System.Text.RegularExpressions.Regex.IsMatch(input1, "^[a-zA-Z+]+$") &&
               System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z0-9,]+$"))
            {
                pc.InsertQuery(tb.Text, tb1.Text, tb2.Text);
                dt1.ItemsSource = pc.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }
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
                string input = tb.Text;
                string input1 = tb1.Text;
                string input2 = tb2.Text;



                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z]+$") &&
                   System.Text.RegularExpressions.Regex.IsMatch(input1, "^[a-zA-Z+]+$") &&
                   System.Text.RegularExpressions.Regex.IsMatch(input2, "^[a-zA-Z0-9,]+$"))
                {
                    object id = (dt1.SelectedItem as DataRowView).Row[0];
                    pc.UpdateQuery(tb.Text, tb1.Text, tb2.Text, Convert.ToInt32(id));
                    dt1.ItemsSource = pc.GetData();
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

        private void dt1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                object selectedRow = (dt1.SelectedItem as DataRowView).Row[1];
                tb.Text = Convert.ToString(selectedRow);
                object nazv = (dt1.SelectedItem as DataRowView).Row[2];
                tb1.Text = Convert.ToString(nazv);
                object op = (dt1.SelectedItem as DataRowView).Row[3];
                tb2.Text = Convert.ToString(op);

            }
        }

        private void ZALKOMP_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Sisadmin).Gr.Content = new ZALIKOMPI();
        }

        private void zal_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Sisadmin).Gr.Content = new zalilalixaml();
        }
    }
}
