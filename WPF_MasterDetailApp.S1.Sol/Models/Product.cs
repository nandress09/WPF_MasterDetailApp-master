using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product : ObservableObject
    {
        #region ENUMS

        public enum GenderType { none, male, female }

        #endregion

        #region FIELDS

        private int _id;
        private string _firstName;
        private string _lastName;
        private int _age;
        private GenderType _gender;
        private string _imageFileName;
        private string _description;
        private DateTime _hireDate;
        private double _averageAnnualGross;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        
        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public double AverageAnnualGross
        {
            get { return _averageAnnualGross; }
            set { _averageAnnualGross = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
