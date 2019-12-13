using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TshirtApp
{

        public class REDBAT
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Name { get; set; }
            public string Size { get; set; }
            public string ShippingAddress { get; set; }
            public bool Done { get; set; }
        }






   
}
