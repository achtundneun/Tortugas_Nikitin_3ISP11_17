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
using System.Windows.Shapes;
using Tortugas_Nikitin_3ISP11_17.DataBases;
using Tortugas_Nikitin_3ISP11_17.ClassHelper;


namespace Tortugas_Nikitin_3ISP11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        List<DIsh> productList = new List<DIsh>();

        public MenuWindow()
        {
            InitializeComponent();

            listProduct.ItemsSource = AppData.Context.DIsh.ToList();

            Filter();
        }

        private void Filter()
        {
            productList = AppData.Context.DIsh.ToList();
        }

        private void Chek_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderwindow = new OrderWindow();
            orderwindow.Show();
            this.Close();
        }

        private void BtnCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoriesWindow categorieswindow = new CategoriesWindow();
            categorieswindow.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainwindow = new MainWindow();
            //mainwindow.Show();
            this.Close();
        }
    }
}
