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
    /// Логика взаимодействия для ZALIKOMPI.xaml
    /// </summary>
    public partial class ZALIKOMPI : Page
    {
        zali_compiTableAdapter zk = new zali_compiTableAdapter();
        zalTableAdapter z = new zalTableAdapter();
        compiTableAdapter pc = new compiTableAdapter();
        public ZALIKOMPI()
        {
            InitializeComponent();
            DT.ItemsSource = zk.GetData();
            cb.ItemsSource = pc.GetData();
            cb1.ItemsSource = z.GetData();
            cb.DisplayMemberPath = "klass";
            cb.SelectedValuePath = "komp_id";
            cb1.DisplayMemberPath = "nazvaniya_zala";
            cb1.SelectedValuePath = "zali_id";
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            
            zk.InsertQuery(Convert.ToInt32(cb.SelectedValue), Convert.ToInt32(cb1.SelectedValue));
            DT.ItemsSource = zk.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (DT.SelectedItem as DataRowView).Row[0];
            zk.DeleteQuery(Convert.ToInt32(id));
            DT.ItemsSource = zk.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (DT.SelectedItem != null)
            {
                object id = (DT.SelectedItem as DataRowView).Row[0];
                zk.UpdateQuery(Convert.ToInt32(cb.SelectedValue), Convert.ToInt32(cb1.SelectedValue),Convert.ToInt32(id));
                DT.ItemsSource = zk.GetData();

            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }

        private void DT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object IDROL = (DT.SelectedItem as DataRowView).Row[0];
            cb.SelectedValue = Convert.ToInt32(IDROL);
            object id = (DT.SelectedItem as DataRowView).Row[1];
            cb1.SelectedValue = Convert.ToInt32(id);
        }
    }
}
