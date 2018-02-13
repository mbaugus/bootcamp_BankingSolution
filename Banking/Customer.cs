using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Customer(int id, string fullname)
        {
            Id = id;
            FullName = fullname;
        }


    }
}
