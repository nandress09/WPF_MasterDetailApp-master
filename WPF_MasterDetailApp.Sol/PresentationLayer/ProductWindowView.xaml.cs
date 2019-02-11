using WPF_MasterDetailApp.Models;
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

namespace WPF_MasterDetailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        #region FIELDS

        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region METHODS (pass events to view model)

        private void Button_Quit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            _productWindowPresenter.AddProduct();
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            _productWindowPresenter.DeleteProduct();
        }

        private void RadioButton_LastNameSort_Checked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                _productWindowPresenter.SortList(ProductWindowPresenter.ProductListSort.LastName);
            }
        }

        private void RadioButton_AgeSort_Checked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                _productWindowPresenter.SortList(ProductWindowPresenter.ProductListSort.Age);
            }
        }

        private void RadioButton_AverageAnnualGrossSort_Checked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                _productWindowPresenter.SortList(ProductWindowPresenter.ProductListSort.AverageAnnualGross);
            }
        }

        private void ComboBox_LastNameFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                ComboBox comboBox = sender as ComboBox;
                string lastName = (comboBox.SelectedItem as ComboBoxItem).Content.ToString();
                _productWindowPresenter.FilterListLastName(lastName);
            }

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Search.Text != "")
            {
               _productWindowPresenter.SearchListLastName(TextBox_Search.Text);
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ProductWindowView(ProductWindowPresenter productPresenter)
        {
            _productWindowPresenter = productPresenter;

            DataContext = _productWindowPresenter;

            InitializeComponent();
        }

        #endregion
    }
}
