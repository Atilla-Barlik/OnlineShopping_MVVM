using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models
{
    public class ProductItem
    {
        private string image;
        public string ImageSource
        { get { return image; } set { image = value; } }
        private string product;
        public string Product
        { get { return product; } set { product = value; } }

        private string id;
        public string ID
        { get { return id; } set { id = value; } }

        private string sCategori1;
        public string SCategori1
        { get { return sCategori1; } set { sCategori1 = value; } }

        private string sCategori2;
        public string SCategori2
        { get { return sCategori2; } set { sCategori2 = value; } }
    }
}
