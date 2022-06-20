using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.ProductService;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MobileGUI.Services.ProductService
{
    public class ProductService : IProductService
    {

        ObservableCollection<ProductItem> products;
        ObservableCollection<Carousel> CarouselItems;

        public Task<ObservableCollection<Carousel>> GetCarouselItems()
        {
            CarouselItems = new ObservableCollection<Carousel>();
            CarouselItems.Add(new Carousel
            {
                ImageSource = "https://www.file.com.tr/uploads/file/mainslider/11-01-2022-14-47-04-slider.png"
            });
            CarouselItems.Add(new Carousel
            {
                ImageSource = "https://www.file.com.tr/uploads/file/mainslider/1-03-2022-16-41-39-file-glutensiz-gida.png"
            });
            CarouselItems.Add(new Carousel
            {
                ImageSource = "https://www.file.com.tr/uploads/file/mainslider/16-02-2022-09-00-00-14-02-2022-15-11-30-harras-slider%20(1)%20(1).png"
            });

            return Task.FromResult(CarouselItems);
        }

        public Task<ObservableCollection<ProductItem>> GetProduct()
        {


            products = new ObservableCollection<ProductItem>();
            foreach (var item in ProductModel.list)
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
