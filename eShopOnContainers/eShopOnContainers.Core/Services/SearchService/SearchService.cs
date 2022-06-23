using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SearchService
{
    public class SearchService : ISearchService
    {
        ObservableCollection<SubProductItem> SearchList;
        SubProductItem s = new SubProductItem();
        public Task<ObservableCollection<SubProductItem>> GetSearchList(object searchTerm)
        {
            string ss = searchTerm as string;
            s.Product = ss;
            SearchList = new ObservableCollection<SubProductItem>();
            foreach (var item in searchListModel.list)
            {
                if (s.Product.ToLower() == item.Product.ToLower() || item.Product.ToLower().StartsWith(s.Product.ToLower()))
                {

                    SearchList.Add(item);
                }
            }
            return Task.FromResult(SearchList);
        }
    }
}
