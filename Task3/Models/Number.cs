using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Models
{
    class Number : INumber
    {
        public int phoneNumber { get;  set; }
        public int iD { get; set; }
        public bool wasTarrifChangedInCurrentMonth { get; set; }
        public double currentAmount { get; set; }
        public string tariffName { get; set; }


        public Number (string _tariffName, int _phoneNumber)
        {
            _tariffName = tariffName;
            _phoneNumber = phoneNumber;
        }




        public void ChangeTarrif()
        {

        }

        public void DepositMoney (double depositeSumm)
        {
            currentAmount = +depositeSumm;
        }
    }
}
