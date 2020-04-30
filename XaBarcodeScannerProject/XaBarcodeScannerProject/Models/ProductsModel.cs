using System;
using System.Collections.Generic;
using System.Text;

namespace XaBarcodeScannerProject.Models
{
    class ProductsModel
    {
        public string BarCode { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
