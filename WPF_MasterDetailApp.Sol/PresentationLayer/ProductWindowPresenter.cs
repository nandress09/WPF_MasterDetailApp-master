using WPF_MasterDetailApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MasterDetailApp.Models
{
    public class ProductWindowPresenter : ObservableObject
    {

        #region ENUMS

        public enum ProductListSort
        {
            LastName,
            Age,
            AverageAnnualGross
        }

        #endregion

        #region FIELDS

        private Company _companyInfo;
        private Product _selectedProduct;
        private List<Product> _allProducts;
        private ObservableCollection<Product> _activeProducts;

        #endregion

        #region PROPERTIES

        public Company CompanyInfo
        {
            get { return _companyInfo; }
            set { _companyInfo = value; }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (_selectedProduct == value)
                {
                    return;
                }
                _selectedProduct = value;
                RaisePropertyChangedEvent("SelectedProduct");
            }
        }

        public List<Product> AllProducts
        {
            get { return _allProducts; }
            set { _allProducts = value; }
        }

        public ObservableCollection<Product> ActiveProducts
        {
            get { return _activeProducts; }
            set { _activeProducts = value; }
        }



        #endregion

        #region CONSTRUCTORS

        public ProductWindowPresenter(Company company, List<Product> products)
        {
            _allProducts = products;
            _companyInfo = company;
            _activeProducts = new ObservableCollection<Product>(products);
        }

        #endregion


        #region METHODS

        public void DeleteProduct()
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show($"Are you sure you want to delete {_selectedProduct.FullName}?", "Delete Character", System.Windows.MessageBoxButton.OKCancel);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                _allProducts.Remove(_selectedProduct);
                _activeProducts.Remove(_selectedProduct);
            }
        }

        public void AddProduct()
        {
            Product newProduct = new Product();
            ProductAddWindowPresenter productAddWindowPresenter = new ProductAddWindowPresenter();
            ProductAddWindowView productAddWindowView = new ProductAddWindowView(newProduct);

            productAddWindowView.ShowDialog();

            if (newProduct != null)
            {
                _allProducts.Add(newProduct);
                _activeProducts = new ObservableCollection<Product>(_allProducts);
                RaisePropertyChangedEvent("ActiveProducts");
            }
        }

        public void SortList(ProductListSort productListSort)
        {
            switch (productListSort)
            {
                case ProductListSort.LastName:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.LastName));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                case ProductListSort.Age:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.Age));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                case ProductListSort.AverageAnnualGross:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.AverageAnnualGross));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                default:
                    break;
            }
        }

        public void FilterListLastName(string lastName)
        {
            if (lastName != "All Names")
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts.Where(c => c.LastName == lastName));
            }
            else
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts);
            }
            RaisePropertyChangedEvent("ActiveProducts");
        }

        public void SearchListLastName(string searchTerm)
        {
            if (searchTerm != "")
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts.Where(c => c.LastName.ToLower().Contains(searchTerm.ToLower())));
            }
            RaisePropertyChangedEvent("ActiveProducts");
        }

        #endregion

        #region EVENTS


        #endregion


    }
}
