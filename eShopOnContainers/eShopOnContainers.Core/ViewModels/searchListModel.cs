﻿using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    internal class searchListModel
    {
        static public ObservableCollection<SubProductItem> list { get; set; }
    }
}
