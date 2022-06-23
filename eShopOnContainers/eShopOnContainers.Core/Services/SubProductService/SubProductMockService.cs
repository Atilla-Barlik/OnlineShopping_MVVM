using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SubProductService
{
    public class SubProductMockService : ISubProductService
    {
        private readonly ObservableCollection<SubProductItem> subProductItems = new ObservableCollection<SubProductItem>
        {
            new SubProductItem
            {
                ImageSource = "https://www.bilgiustam.com/resimler/2015/11/elma.jpg",
                    Product = "Elma",
                    ID = "0",
                    Price = "10 TL",
                    Favorite = "0",
                    Aciklama = "Amasya Elması ",
                    SCategori = "0"
            },

            new SubProductItem
            {
                ImageSource = "https://sandalcisarkuteri.com/wp-content/uploads/2020/06/DANA-ANTR%C4%B0KOT-KG-300x300.jpg",
                    Product = "Dana Pirzola",
                    ID = "1",
                    Price = "180 TL",
                    Favorite = "0",
                    Aciklama = "1500gr",
                    SCategori = "0"
            }
        };
        private ObservableCollection<SubProductItem> s;

        public Task<ObservableCollection<SubProductItem>> AddBasket(SubProductItem subProductItem)
        {
            throw new NotImplementedException();
        }

        public Task<ObservableCollection<SubProductItem>> AddFavorite(string Product)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<SubProductItem>> GetSubProduct(string id)
        {
            await Task.Delay(10);
            return subProductItems;
        }

        public async Task<ObservableCollection<SubProductItem>> ListScategori(string sCategoriNumber, string id)
        {
            s = new ObservableCollection<SubProductItem>();
            await Task.Delay(10);
            foreach(var item in subProductItems)
            {
                if(item.ID == id && item.SCategori== sCategoriNumber)
                {
                    s.Add(item);
                }
            }
            return await Task.FromResult(s);
        }
    }
}
