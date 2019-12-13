using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TshirtWeb.Api.Modules;


namespace TshirtWeb.Api.Data
{
    public static class SeedData
    {

        public static void Initialize(Ygen context)
        {
            if (!context.RedBats.Any())
            {
                context.RedBats.AddRange(
                    new RedBat
                    {

                        Name = "",
                        Size = "",
                        ShippingAddress = ""
                      
                    }


               ) ;

                context.SaveChanges();
            }
        }


    }
}
