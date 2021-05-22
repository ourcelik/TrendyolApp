using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.Products
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor
                .Field(p => p.Category)
                .ResolveWith<Resolvers>(r => r.GetCategory(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Ürün kategorisi");
            descriptor
                .Field(p => p.TopPhoto)
                .ResolveWith<Resolvers>(r => r.GetTopPhoto(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Ürün ana fotoğraf");
            descriptor
                .Field(p => p.Currency)
                .ResolveWith<Resolvers>(r => r.GetCurrency(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Ürün fiyat para birimi");
            descriptor
                .Field(p => p.Photos)
                .ResolveWith<Resolvers>(r => r.GetPhotos(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Ürün Fotoğrafları");
            descriptor
                .Field(p => p.SubCategory)
                .ResolveWith<Resolvers>(r => r.GetSubCategory(default!, default!))
                .UseDbContext<TrendyolAppDbContext>();
            descriptor
                .Field(p => p.SubSubCategory)
                .ResolveWith<Resolvers>(r => r.GetSubSubCategory(default!, default!))
                .UseDbContext<TrendyolAppDbContext>();

        }
        private class Resolvers
        {
            public Category GetCategory(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Categories.SingleOrDefault(c => c.Id == product.CategoryId);
            }
            public Photo GetTopPhoto(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Photos.SingleOrDefault(p => p.Id == product.TopPhotoId);
            }
            public Currency GetCurrency(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Currencies.SingleOrDefault(c => c.Id == product.CurrencyId);
            }
            public IQueryable<Photo> GetPhotos(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Photos.Where(p => p.ProductId == product.Id);
            }
            public SubCategory GetSubCategory(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.SubCategories.SingleOrDefault(c => c.Id == product.SubCategoryId);
            }
            public SubSubCategory GetSubSubCategory(Product product, [ScopedService] TrendyolAppDbContext context)
            {
                return context.SubSubCategories.SingleOrDefault(c => c.Id == product.SubSubCategoryId);
            }

        }

    }
}
