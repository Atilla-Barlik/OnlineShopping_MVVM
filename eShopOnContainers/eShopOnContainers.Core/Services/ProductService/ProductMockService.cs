using eShopOnContainers.Core.Models;
using MobileGUI.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.ProductService
{

    public class ProductMockService:IProductService
    {

        private ObservableCollection<Carousel> MockCarouselItem = new ObservableCollection<Carousel>
        {
            new Carousel { ImageSource = "https://www.file.com.tr/uploads/file/mainslider/11-01-2022-14-47-04-slider.png" },
            new Carousel { ImageSource = "https://www.file.com.tr/uploads/file/mainslider/1-03-2022-16-41-39-file-glutensiz-gida.png" }
        };

        private ObservableCollection<ProductItem> MockProductItem = new ObservableCollection<ProductItem>
        {

            new ProductItem {

                ImageSource = "https://pluse.com.tr/images/thumb/1078.jpg",
                Product = "Meyve Sebze",
                ID = "0",
                SCategori1 = "Meyve",
                SCategori2 = "Sebze" },
            new ProductItem {
             ImageSource = "https://www.festiva.com.tr/img/cms/category_73.jpg",
                Product = "İçecek",
                ID = "2",
                SCategori1 = "Gazsız İçecek",
                SCategori2 = "Gazlı İçecek"}
        };


        public Task<ObservableCollection<Carousel>> GetCarouselItems()
        {
            return Task.FromResult(MockCarouselItem);
        }

        public Task<ObservableCollection<ProductItem>> GetProduct()
        {
            return Task.FromResult(MockProductItem);
        }
    }
}
