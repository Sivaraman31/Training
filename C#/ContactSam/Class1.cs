using System;
using System.Collections.Generic;
using System.Text;

namespace ContactSam
{
    class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Contact(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
