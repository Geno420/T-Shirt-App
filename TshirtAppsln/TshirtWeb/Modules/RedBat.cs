using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;


namespace TshirtWeb.Api.Modules
{
    public class RedBat
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Size { get; set; }
        public string ShippingAddress { get; set; }
        public bool Done { get; set; }
















        



    }
}
