using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStoreAPI.Dto
{
    public class ProductList
    {
        public string Sort { get; set; }
        public bool Desc { get; set; }
        public int Take { get; set; }
        public string Filter { get; set; }

        //public ProductList()
        //{
        //    Take = 10;
        //}
    }
}
