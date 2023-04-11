using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для adminpage1.xaml
    /// </summary>
    public partial class adminpage1 : Page
    {
        roliTableAdapter rol = new roliTableAdapter();
        public adminpage1()
        {
            InitializeComponent();
            dt1.ItemsSource = rol.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dt1.SelectedItem != null)
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
                rol.InsertQuery(tbx.Text);
                dt1.ItemsSource = rol.GetData();
            }
            else
            {
                MessageBox.Show("неправильный ввод");
            }


        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (dt1.SelectedItem as DataRowView).Row[0];
            rol.DeleteQuery(Convert.ToInt32(id));
            dt1.ItemsSource = rol.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (dt1.SelectedItem != null)
            {
                string input = tbx.Text;

                if (System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Zа-яА-Я]+$"))
                {
                    object id = (dt1.SelectedItem as DataRowView).Row[0];
                    rol.UpdateQuery(tbx.Text, Convert.ToInt32(id));
                    dt1.ItemsSource = rol.GetData();
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

        private void parollogin_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Admin).fr.Content = new LOGPAROL();
        }

        private void Polzovatily_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Admin).fr.Content = new POLZOVATILY();
        }

        private void POLZ_KLASS_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Admin).fr.Content = new POLZKLL();
        }

        private void import_Click(object sender, RoutedEventArgs e)
        {
            List<JSON> forImport = DEER.DeserializeObject<List<JSON>>();
            foreach (var item in forImport)
            {
                rol.InsertQuery(item.opisaniye_roli);

            }
            dt1.ItemsSource = null;
            dt1.ItemsSource = rol.GetData();
        }
    }
}
