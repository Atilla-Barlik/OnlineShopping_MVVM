
using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MobileGUI.Services.ProductService
{
    public interface IProductService
    {
        Task<ObservableCollection<Carousel>> GetCarouselItems();
        Task<ObservableCollection<ProductItem>> GetProduct();
    }
}
