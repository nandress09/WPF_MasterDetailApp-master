using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        

        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;


        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public ProductBL()
        {
            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
            return new Product
            {
                Id = 1,
                OwnerName = "Philip",
                Description = "Freshly built in 2017. One acre of land total. No neibors for miles. Big Basement.",
                Price = 600000.00,
                Style = Product.HouseStyle.Modern,
                Beds = 2,
                Baths = 2,
                ListingDateTime = new DateTime(2019, 01, 26),
                ImageFileName = "house.jpg"
            };
        }
        private Company GetCompanyData ()
        {
            return new Company
            {
                Name = "Sara Lee Realestate",
                Address = "9887 Carriage St.",
                City = "Traverse City"
            };
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
