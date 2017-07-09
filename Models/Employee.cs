using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Models
{
    public class Employee
    {
        private Guid _employeeId;
        private string _firstName, _lastName, _position, _email, _hashedPwd, _saltValue;
        private DateTime _registeredOn, _DOB;

        #region Public Properties
        public Guid EmployeeID
        {
            get { return _employeeId; }
            set
            {
                if (!object.Equals(_employeeId, value))
                    _employeeId = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!object.Equals(_firstName, value))
                    _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!object.Equals(_lastName, value))
                    _lastName = value;
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (!object.Equals(_position, value))
                    _position = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!object.Equals(_email, value))
                    _email = value;
            }
        }

        public DateTime DOB
        {
            get { return _DOB; }
        }

        public string Password
        {
            get { return _hashedPwd; }
            set
            {
                if (!object.Equals(_hashedPwd, value))
                    _hashedPwd = value;
            }
        }

        public string SaltValue
        {
            get { return _saltValue; }
            set
            {
                if (!object.Equals(_saltValue, value))
                    _saltValue = value;
            }
        }
        #endregion

        public Employee(string FirstName, string LastName, DateTime DOB, string Position, string Email, string Password, string Salt)
        {
            EmployeeID = new Guid();
            _registeredOn = DateTime.Now;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this._DOB = DOB;
            this.Position = Position;
            this.Email = Email;
            this.Password = Password;
            this.SaltValue = Salt;
        }
        public Employee()
        {

        }
    }
}
