using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SepetimService
{
    public class SepetimService : ISepetimService   
    {
        ObservableCollection<SubProductItem> products;
        public Task<ObservableCollection<SubProductItem>> GetSepet()
        {


            products = new ObservableCollection<SubProductItem>();
            foreach (var item in Model.list)
            {
                if (item.Product != null)
                {
                    products.Add(item);
                }
            }



            return Task.FromResult(products);
        }
    }
}
