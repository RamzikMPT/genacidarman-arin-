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
    /// Логика взаимодействия для ZALIUSR.xaml
    /// </summary>
    public partial class ZALIUSR : Page
    {
        zalTableAdapter zal = new zalTableAdapter();
        public ZALIUSR()
        {
            InitializeComponent();
            uyt.ItemsSource = zal.GetData();
        }
    }
}
