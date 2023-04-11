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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        sotrudnikiTableAdapter whod = new sotrudnikiTableAdapter();
        polzovatilyTableAdapter whod2 = new polzovatilyTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alllogins = whod.GetData().Rows;

            for (int i = 0; i < alllogins.Count; i++)
            {
                if (alllogins[i][3].ToString() == LOGIN.Text &&
                    alllogins[i][4].ToString() == PASSWORD.Password)
                {
                    int roleid = (int)alllogins[i][5];
                    switch(roleid)
                    {
                        case 1:
                            Application.Current.MainWindow = new Admin();
                            Application.Current.MainWindow.Show();
                            break;
                       case 2:
                            Application.Current.MainWindow = new Sisadmin();
                            Application.Current.MainWindow.Show();
                            break;
                            case 3:
                            Application.Current.MainWindow = new Kassir();
                            Application.Current.MainWindow.Show();
                            break;


                        
                    }
                }
               
            }
            var alllog2 = whod2.GetData().Rows;
            for (int j = 0; j < alllog2.Count; j++)
            {
                if (alllog2[j][6].ToString() == LOGIN.Text &&
                    alllog2[j][7].ToString() == PASSWORD.Password)
                {
                    Application.Current.MainWindow = new Users();
                    Application.Current.MainWindow.Show();

                    break;
                }

            }
        }
    }
}
