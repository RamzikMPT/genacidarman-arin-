using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для dlausera.xaml
    /// </summary>
    public partial class dlausera : Page
    {
        tarifiTableAdapter tar = new tarifiTableAdapter();
        public dlausera()
        {
            InitializeComponent();
            TBX.ItemsSource = tar.GetData();
        }

        private void ZALI_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as Users).tt.Content = new ZALIUSR();
        }
    }
}
