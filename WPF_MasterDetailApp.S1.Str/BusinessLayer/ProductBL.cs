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
        {   _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_ProductWindowPresenter);
            _productWindowView.DataContext = productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
           

            //short way to send stuff
            return new Product
            {
                Id = 1
                FirstName = "Fred",
                LastName = "Flinstone",
                Age = 33,
                Gender = Product.GenderType.male,
                AverageAnnualGross = 333,
                HireDate = DateTime.Parse("1/22/1958"),
                Description = "The Big Guy",
                ImagefileName = "fred_flinston.jpg"

            };


        }
        private Company GetCompanyData ()
        {
            //long way to send stuff
            Company company = new Company();
            company.Name = "Sara Lee Cats";
            company.Address = "west third street";
            company.City = "Traverse City";

            return company;
        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
