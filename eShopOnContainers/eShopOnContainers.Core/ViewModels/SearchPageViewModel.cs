using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.SearchService;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    internal class SearchPageViewModel : ViewModelBase
    {
        ISearchService searchService;

        private ObservableCollection<SubProductItem> sProducts;
        public ObservableCollection<SubProductItem> SProducts
        {
            get => sProducts;
            set
            {
                if (value == SProducts) return;
                sProducts = value;

                OnPropertyChanged();
            }
        }
        public SearchPageViewModel()
        {
            SProducts = new ObservableCollection<SubProductItem>();

            searchCommand = new Command(Search);
        }
        private ICommand searchCommand;
        public ICommand SearchCommand { get { return searchCommand ?? (searchCommand = new Command<object>(Search)); } }


        SubProductItem s = new SubProductItem();
        private async void Search(object searchTerm)
        {
            sProducts.Clear();
            string ss = SearchTerm as string;


            searchService = new SearchService();

            SProducts = await searchService.GetSearchList(ss);

        }


        public string SearchTerm { get; set; }

    }
}
