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
    }
}
