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
        ProductWindowPresenter __productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            __productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(__productWindowPresenter);
            _productWindowView.DataContext = __productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Troglodyte Talent Agency",
                Address = "465 Jurassic Lane",
                City = "Bedrock"
            };
        }

        private Product GetProductData()
        {
            return
                new Product()
                {
                    Id = 1,
                    FirstName = "Fred",
                    LastName = "Flintstone",
                    Age = 28,
                    Gender = Product.GenderType.male,
                    ImageFileName = "fred_flintstone.jpg",
                    Description = "Fred is the main character of the series. He's an accident-prone bronto-crane operator at the Slate Rock and Gravel Company and the head of the Flintstone household. He is quick to anger (usually over trivial matters), but is nonetheless a very loving husband and father. He's also good at bowling and is a member of the fictional Loyal Order of Water Buffaloes (Lodge No. 26), a men-only club paralleling real-life fraternities such as the Loyal Order of Moose.",
                    HireDate = DateTime.Parse("03-23-1963"),
                    AverageAnnualGross = 23445.85
                };
        }

    #endregion

    #region EVENTS


    #endregion

}
}
