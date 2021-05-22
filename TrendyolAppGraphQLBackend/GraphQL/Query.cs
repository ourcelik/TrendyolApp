using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;

namespace TrendyolAppGraphQLBackend.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Category> GetCategory([ScopedService] TrendyolAppDbContext context)
        {
            return context.Categories;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Photo> GetPhoto([ScopedService] TrendyolAppDbContext context)
        {
            return context.Photos;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CarouselAd> GetCarouselAd([ScopedService] TrendyolAppDbContext context)
        {
            return context.CarouselAds;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Cart> GetCart([ScopedService] TrendyolAppDbContext context)
        {
            return context.Carts;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Currency> GetCurrency([ScopedService] TrendyolAppDbContext context)
        {
            return context.Currencies;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProduct([ScopedService] TrendyolAppDbContext context)
        {
            return context.Products;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SubCategory> GetSubCategory([ScopedService] TrendyolAppDbContext context)
        {
            return context.SubCategories;
        }
        [UseDbContext(typeof(TrendyolAppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SubSubCategory> GetSubSubCategory([ScopedService] TrendyolAppDbContext context)
        {
            return context.SubSubCategories;
        }



    }
}
