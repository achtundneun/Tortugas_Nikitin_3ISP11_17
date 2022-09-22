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
using Tortugas_Nikitin_3ISP11_17.Windows;
using Tortugas_Nikitin_3ISP11_17.ClassHelper;
using Tortugas_Nikitin_3ISP11_17.Properties;

namespace Tortugas_Nikitin_3ISP11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        List<DIsh> dishList = new List<DIsh>();
        List<string> listSort = new List<string>() { "По умолчанию", "По названию", "По фамилии автора", "По имени автора", "По издательству" };

        public MenuWindow()
        {
            InitializeComponent();

            //cmbSort.ItemsSource = listSort;
            //cmbSort.SelectedIndex = 0;

            ////Filter();
            dishList = AppData.Context.DIsh.ToList();
        }



        //private void Filter()
        //{
        //    bookList = AppData.Context.Book.Where(i => i.IsDeleted == false).ToList();
        //    bookList = bookList.
        //                    Where(i => i.TitleBook.ToLower().Contains(SearchBookName.Text.ToLower())).ToList();

        //    switch (cmbSort.SelectedIndex)
        //    {
        //        case 0:
        //            bookList = bookList.OrderBy(i => i.Id).ToList();
        //            break;
        //        case 1:
        //            bookList = bookList.OrderBy(i => i.TitleBook).ToList();
        //            break;
        //        default:
        //            bookList = bookList.OrderBy(i => i.Id).ToList();
        //            break;
        //    }

        //    listBook.ItemsSource = bookList;
        //}


        //private void btnAddBook_Click(object sender, RoutedEventArgs e)
        //{
        //    BookAddWindow bookAddWindow = new BookAddWindow();
        //    this.Opacity = 0.2;
        //    bookAddWindow.ShowDialog();
        //    this.Opacity = 1;
        //    Filter();
        //}

        //private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    Filter();
        //}

        //private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Filter();
        //}

        //private void listBook_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Delete)
        //    {
        //        if (listDIsh.SelectedItem is BD.DIsh)
        //        {
        //            try
        //            {
        //                var item = listDish.SelectedItem as BD.DIsh;
        //                var resultClick = MessageBox.Show("Вы уверены?", "Подтвердите удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //                if (resultClick == MessageBoxResult.Yes)
        //                {
        //                    AppData.Context.Book.Remove(item);
        //                    AppData.Context.SaveChanges();
        //                    MessageBox.Show("Книга успешно удалена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        //                    Filter();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message.ToString());
        //            }
        //        }
        //    }
        //}

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        //private void listBook_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    var editBook = new BD.Book();

        //    if (listBook.SelectedItem is BD.Book)
        //    {
        //        editBook = listBook.SelectedItem as BD.Book;
        //    }
        //    BookAddWindow editBookWindow = new BookAddWindow(editBook);
        //    this.Opacity = 0.2;
        //    editBookWindow.ShowDialog();
        //    this.Opacity = 1;
        //    Filter();
    }
}

