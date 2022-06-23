using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace eShopOnContainers.Test.ViewModels
{
    public class SepetimViewModelTests
    {
        [Fact]
        public void IsRefreshingFalseTest()
        {
            Xamarin.Forms.Forms.Init();
            var sepetimViewModel = new SepetimViewModel();

            Assert.False(sepetimViewModel.IsRefreshing);
        }
        [Fact]
        public void IsRefreshingTrueTest()
        {
            Xamarin.Forms.Forms.Init();
            var sepetimViewModel = new SepetimViewModel();

            Assert.True(sepetimViewModel.IsRefreshing);
        }

        [Fact]
        public void RefreshCommandIsNotNullWhenViewModelInstantiatedTest()
        {
            Xamarin.Forms.Forms.Init();
            var sepetimViewModel = new SepetimViewModel();
            Assert.NotNull(sepetimViewModel.RefreshCommand);
        }
    }
}
