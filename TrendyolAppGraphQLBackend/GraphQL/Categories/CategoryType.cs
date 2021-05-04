using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.Categories
{
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            descriptor.Description("Ürün Kategorilerini Listeler");
            descriptor
                .Field(c => c.Id)
                .Description("Unique Id");
            descriptor
                .Field(c => c.CategoryName)
                .Description("Kategori ismi");
            descriptor
                .Field(c => c.Products)
                .ResolveWith<Resolvers>(r => r.GetProducts(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Kategoriye Ait Ürünler");
        }
        private class Resolvers
        {
            public IQueryable<Product> GetProducts(Category category, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Products.Where(p => p.CategoryId == category.Id);
            }
        }
    }
}
