using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models
{
    public  class SubProductItem
    {
        private string image;
        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }

        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string favorite;
        public string Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }
        private string aciklama;
        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
    }
}
