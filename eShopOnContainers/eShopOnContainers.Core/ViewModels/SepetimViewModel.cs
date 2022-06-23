using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.SepetimService;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class SepetimViewModel : ViewModelBase
    {
        private bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set { isRefreshing = value; OnPropertyChanged(); }
        }
        public Command RefreshCommand { get; set; }
        ISepetimService sepetimService;
        private ObservableCollection<SubProductItem> basketList;
        public ObservableCollection<SubProductItem> BasketList
        {
            get => basketList;
            set
            {
                if (value == BasketList) return;
                basketList = value;

                OnPropertyChanged();
            }
        }

        public SepetimViewModel()
        {
            BasketList = new ObservableCollection<SubProductItem>();

            getSepet();

            RefreshCommand = new Command(OnRefresh);
        }

        public async void getSepet()
        {
            sepetimService = new SepetimService();

            BasketList = await sepetimService.GetSepet();
        }

        private void OnRefresh()
        {
            Task.Run(LoadData);
        }

        public async Task LoadData()
        {
            IsRefreshing = true;
            getSepet();
            IsRefreshing = false;
        }

    }
}
