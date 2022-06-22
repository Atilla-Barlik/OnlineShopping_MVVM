using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.FavoriteService
{
    public class FavoriteService : IFavoriteService
    {
        ObservableCollection<SubProductItem> FavoriteList;
        public Task<ObservableCollection<SubProductItem>> GetFavorite()
        {

            FavoriteList = new ObservableCollection<SubProductItem>();
            foreach (var item in searchListModel.list)
            {
                if (item.Favorite == "1")
                    FavoriteList.Add(item);
            }



            return Task.FromResult(FavoriteList);
        }
    }
}
