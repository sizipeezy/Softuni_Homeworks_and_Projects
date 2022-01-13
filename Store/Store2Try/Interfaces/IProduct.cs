using System;
using System.Collections.Generic;
using System.Text;

namespace Store2Try
{
    public interface IProduct
    {
        public string Name { get; }
        public string Brand { get; }

        public double Price { get; }


    }
}
