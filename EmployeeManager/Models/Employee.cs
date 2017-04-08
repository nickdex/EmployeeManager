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
        private int? _id;
        private string _name;
        private byte? _age;
        private string _firstName;
        private string _lastName;

        public int? Id 
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

        public byte? Age
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
                if (string.IsNullOrEmpty(Name))
                {
                    return "Name is required";
                }
                if (Id < 0)
                {
                    return "Id is negative";
                }
                if (Id == null)
                {
                    return "Id is required";
                }
                if (Age == null)
                {
                    return "Age is required";
                }
                return null;
            }
        }
    }
}
