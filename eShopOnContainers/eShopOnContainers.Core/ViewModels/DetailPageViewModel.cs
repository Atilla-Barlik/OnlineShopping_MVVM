using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    internal class DetailPageViewModel
    {
        private SubProductItem selectedItemDetails;
        public string ImageSource { get; set; }
        public string Price { get; set; }
        public string Product { get; set; }

        public string Favorite { get; set; }
        public string Aciklama { get; set; }


        public DetailPageViewModel(SubProductItem selectedItemDetails)
        {
            this.selectedItemDetails = selectedItemDetails;

            ImageSource = selectedItemDetails.ImageSource;
            Price = selectedItemDetails.Price;
            Product = selectedItemDetails.Product;
            Favorite = selectedItemDetails.Favorite;
            Aciklama = selectedItemDetails.Aciklama;
            

        }
    }
}
