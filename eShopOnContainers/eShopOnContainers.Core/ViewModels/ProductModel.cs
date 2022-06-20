using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    internal class ProductModel
    {
        static public ObservableCollection<ProductItem> list { get; set; }
    }
}
