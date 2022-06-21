using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SubProductService
{
    public interface ISubProductService
    {
        Task<ObservableCollection<SubProductItem>> AddBasket(SubProductItem subProductItem);
        Task<ObservableCollection<SubProductItem>> AddFavorite(string Product);
        Task<ObservableCollection<SubProductItem>> GetSubProduct(string id);
    }
}
