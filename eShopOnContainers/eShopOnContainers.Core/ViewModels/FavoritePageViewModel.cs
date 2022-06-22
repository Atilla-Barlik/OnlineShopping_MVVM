using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.FavoriteService;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    internal class FavoritePageViewModel : ViewModelBase
    {
        IFavoriteService favoriteService;
        private bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set { isRefreshing = value; OnPropertyChanged(); }
        }

       

        public Command RefreshCommand { get; set; }

        private ObservableCollection<SubProductItem> favoriteList;
        public ObservableCollection<SubProductItem> FavoriteList
        {
            get => favoriteList;
            set
            {
                if (value == FavoriteList) return;
                favoriteList = value;
                

                OnPropertyChanged();
            }

        }
        public FavoritePageViewModel()
        {

            FavoriteList = new ObservableCollection<SubProductItem>();

            getFavoriteItems();

            RefreshCommand = new Command(OnRefresh);

        }

        public async void getFavoriteItems()
        {
            favoriteService = new FavoriteService();

            FavoriteList = await favoriteService.GetFavorite();
            
        }

        private void OnRefresh()
        {
            Task.Run(LoadData);
        }

        public async Task LoadData()
        {
            IsRefreshing = true;

            getFavoriteItems();
            IsRefreshing = false;
        }
    }
}
