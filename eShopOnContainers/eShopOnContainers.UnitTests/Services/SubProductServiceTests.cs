using eShopOnContainers.Core.Services.SubProductService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eShopOnContainers.UnitTests.Services
{
    public class SubProductServiceTests
    {
        [Fact]
        public async Task getFakeSubProductItems()
        {
            var subProductMockService = new SubProductMockService();
            var items = await subProductMockService.GetSubProduct("2");

            Assert.NotNull(items);
        }

        [Fact]
        public async Task getFakeSubProductItemsWithCategoriNumber()
        {
            var campaignMockService = new SubProductMockService();
            var items = await campaignMockService.ListScategori("0","1");

            Assert.NotEmpty(items);
        }
    }
}
