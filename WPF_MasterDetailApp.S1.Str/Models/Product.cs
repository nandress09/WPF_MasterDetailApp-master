using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum HouseStyle { undefined, Modern, Traditional }

        #endregion

        #region FIELDS

        private int _id;
        private string _ownerName;
        private string _description;
        private double _price;
        private int _baths;
        private int _beds;
        private DateTime _listingDateTime;
        private HouseStyle _style;
        private string _imageFileName;

        
        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Baths
        {
            get { return _baths; }
            set { _baths = value; }
        }

        public int Beds
        {
            get { return _beds; }
            set { _beds = value; }
        }

        public DateTime ListingDateTime
        {
            get { return _listingDateTime; }
            set { _listingDateTime = value; }
        }

        public HouseStyle Style
        {
            get { return _style; }
            set { _style = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        //sprint two stuff public Product()
        // {

        // }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
