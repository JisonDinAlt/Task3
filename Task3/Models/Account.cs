using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Models
{
    public class Account
    {
        public string name { get; protected set; }
        public int number { get; protected set; }
        public string tariff { get; protected set; }

        List<INumber> numbers = new List<INumber>();
    }
}
