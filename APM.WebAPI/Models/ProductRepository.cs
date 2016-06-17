using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class ProductRepository
    {
        ///<summary>
        ///Creates a new product with default vlaues
        ///</summary>
        ///<return></returns>
        internal Product Create()
        {
            Product product = new Product
            {
                ReleaseDate = DateTime.Now
            };
            return product;
        }
        

    }
}