using eShopOnContainers.Core.Services.Catalog;
using eShopOnContainers.Core.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eShopOnContainers.UnitTests.Services
{
    public class ProductServiceTest
    {
        [Fact]
        public async Task getFakeProductItem()
        {
            var productMockService = new ProductMockService();
            var product = await productMockService.GetProduct();

            Assert.NotEmpty(product);
        }

        [Fact]
        public async Task getFakeCarouselItem()
        {
            var carouselMockService = new ProductMockService();
            var carousel = await carouselMockService.GetCarouselItems();

            Assert.NotEmpty(carousel);
        }
    }
}
