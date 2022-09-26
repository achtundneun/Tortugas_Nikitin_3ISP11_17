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
using Tortugas_Nikitin_3ISP11_17.DataBases;
using Tortugas_Nikitin_3ISP11_17.Windows;
using Tortugas_Nikitin_3ISP11_17.ClassHelper;
using Tortugas_Nikitin_3ISP11_17.Properties;
using Tortugas_Nikitin_3ISP11_17.Windows;

namespace Tortugas_Nikitin_3ISP11_17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuwindow = new MenuWindow();
            menuwindow.Show();
            this.Close();
        }
    }
}


        
        
        
        
        
        
        
    
       




