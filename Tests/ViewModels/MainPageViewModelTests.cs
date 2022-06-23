using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eShopOnContainers.Test.ViewModels
{
    public class MainPageViewModelTests
    {
        [Fact]
        public void IsBusyPropertyIsFalseWhenViewModelInstantiatedTest()
        {
            var mainPageViewModel = new MainPageViewModel();

            Assert.False(mainPageViewModel.IsBusy);
        }
        [Fact]
        public async Task IsBusyPropertyIsTrueAfterViewModelInitializationTest()
        {
            var mainPageViewModel = new MainPageViewModel();
            await mainPageViewModel.InitializeAsync(null);
            Assert.True(mainPageViewModel.IsBusy);
        }

        [Fact]
        public void SettingsCommandIsNotNullWhenViewModelInstantiatedTest()
        {
            var mainPageViewModel = new MainPageViewModel();
            Assert.NotNull(mainPageViewModel.MyCollectionSelectedCommand);
        }
    }
}
