using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Models
{
    class Tariff
    {
        public string name { get; }
        public int id { get; }
        public string description { get; }
       
        public Tariff (string _name, int _id, string _description)
        {
            _name = name;
            _id = id;
            _description = description;
        }
    }
}
