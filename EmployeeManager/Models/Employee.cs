using EmployeeManager.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class Employee : BaseModel, IDataErrorInfo
    {
        private int _id;
        private string _name;
        private byte _age;

        public int Id 
        {
            get
            {
                return _id;
            }
            set 
            {
                _id = value;
                onPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                onPropertyChanged();
            }
        }

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                onPropertyChanged();
            }
        }

        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                if (Id <= 0 && columnName == Id.ToString())
                {
                    return "Id must be positive";
                }
                if (Age <= 0 && columnName == Age.ToString())
                {
                    return "Age must be positive";
                }
                if (string.IsNullOrEmpty(Name) && Name == columnName)
                {
                    return "Name is required";
                }
                return null;
            }
        }
    }
}
