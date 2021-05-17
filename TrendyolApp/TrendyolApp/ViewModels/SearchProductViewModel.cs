﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;

namespace TrendyolApp.ViewModels
{
    class SearchProductViewModel : BaseViewModel
    {

        public List<ProductModel> GetSearchData(Expression<Func<ProductModel, bool>> filter = null)
        {
            return filter == null ? ProductData.products.ToList()
                   : ProductData.products.Where(filter.Compile()).ToList();
        }
    }
}