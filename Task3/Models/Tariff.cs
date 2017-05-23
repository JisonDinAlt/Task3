using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Models
{
    class Tariff
    {
        //тарифы
        //    1. Unlim - Безлимит, стоимость 1000 в месяц 
        //    2. Fre100 - 100 бесплатных минут, остальные по 10 руб мин, цена 500
        //    3. Free50 - 50 бесплатных минут, остальные по 10 руб мин, цена 250
        //    4. Free10 - 10 бесплатных минут, остальные по 10 руб мин, цена 100
        //    5. Basic -  0 бесплатных, тарификация 20 руб мин, цена 0


        public string name { get; }
        public int id { get; }
        public bool isUnlim { get; }
        public double freeMinuts { get; set; }
        public double cost { get; }
         
        


        public Tariff (string _name, int _id)
        {
            _name = name;
            _id = id;
           
        }
    }
}
