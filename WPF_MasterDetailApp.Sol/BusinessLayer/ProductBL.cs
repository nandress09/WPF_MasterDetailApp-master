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


        private List<Product> GetProductData()
        {
            return new List<Product>()
            {
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
                },
                new Product()
                {
                   Id = 2,
                   FirstName = "Wilma",
                   LastName = "Flintstone",
                   Age = 28,
                   Gender = Product.GenderType.female,
                   ImageFileName = "wilma_flintstone.jpg",
                   Description = "Wilma is Fred's wife. She is more intelligent and level-headed than her husband, though she often has a habit of spending money recklessly (with Betty and her catchphrase being 'Da-da-da duh da-da CHARGE IT!!'). She's often a foil to Fred's poor behavior.",
                   HireDate = DateTime.Parse("03-23-1963"),
                   AverageAnnualGross = 45834.00
                },
                new Product()
                {
                   Id = 3,
                   FirstName = "Pebbles",
                   LastName = "Flintstone",
                   Age = 1,
                   Gender = Product.GenderType.female,
                   ImageFileName = "pebbles_flintstone.jpg",
                   Description = "Pebbles is the Flintstones' infant daughter, who is born near the end of the third season.",
                   HireDate = DateTime.Parse("03-23-1966"),
                   AverageAnnualGross = 8364.75
                },
                                new Product()
                {
                   Id = 4,
                   FirstName = "Barney",
                   LastName = "Rubble",
                   Age = 27,
                   Gender = Product.GenderType.male,
                   ImageFileName = "barney_rubble.jpg",
                   Description = "Barney is the secondary main character and Fred's best friend and next-door neighbor. His occupation is, for the most part of the series, unknown, though later series depict him working in the same quarry as Fred. He shares many of Fred's interests such as bowling and golf, and is also a member of the Loyal Order of Water Buffaloes. Though Fred and Barney frequently get into feuds with one another (usually due to Fred's short temper), their deep fraternal bond remains evident.",
                  HireDate = DateTime.Parse("03-24-1963"),
                  AverageAnnualGross = 23445.85
                },
                new Product()
                {
                   Id = 5,
                   FirstName = "Betty",
                   LastName = "Rubble",
                   Age = 26,
                   Gender = Product.GenderType.female,
                   ImageFileName = "betty_rubble.gif",
                   Description = "Betty is Barney's wife and Wilma's best friend. Like Wilma, she, too, has a habit of carelessly spending money.",
                   HireDate = DateTime.Parse("03-24-1963"),
                   AverageAnnualGross = 45834.00
                },
                new Product()
                {
                   Id = 6,
                   FirstName = "Bamm-Bamm",
                   LastName = "Rubble",
                   Age = 2,
                   Gender = Product.GenderType.male,
                   ImageFileName = "bamm_bamm_rubble.gif",
                   Description = "Bamm-Bamm is the Rubbles' abnormally strong adopted son, whom they adopt during the fourth season.",
                   HireDate = DateTime.Parse("03-23-1966"),
                   AverageAnnualGross = 7548.75
                },
                new Product()
                {
                   Id = 7,
                   FirstName = "Dino",
                   LastName = "",
                   Age = 7,
                   Gender = Product.GenderType.female,
                   ImageFileName = "dino.jpg",
                   Description = "Dino, a prosauropod dinosaur, is the Flintstones' pet that barks and generally acts like a dog. A running gag in the series involves Dino knocking down Fred out of excitement and licking him repeatedly. Though this irritates Fred a lot, he generally likes Dino very much.",
                   HireDate = DateTime.Parse("03-23-1964"),
                   AverageAnnualGross = 10087.75
                }
            };
        }

        #endregion

        #region EVENTS


        #endregion

    }
}
