using System;

namespace Assignment.CafeExternal
{
    class Customer
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; } }
        private string _EmailAddress;
        public string EmailAddress { get { return _EmailAddress; } set { _EmailAddress = value; } }
        private UInt32 _TeleNumber;
        public UInt32 TeleNumber { get { return _TeleNumber; } set { _TeleNumber = value; } }

        public Customer(string name, string emailAddress, string teleNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            TeleNumber = Convert.ToUInt32(teleNumber);
        }
    }
}
