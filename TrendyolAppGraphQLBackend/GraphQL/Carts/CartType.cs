using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.Carts
{
    public class CartType : ObjectType<Cart>
    {
        protected override void Configure(IObjectTypeDescriptor<Cart> descriptor)
        {
            descriptor.Description("Sepet Ürünleri");

            descriptor
               .Field(c => c.Product)
               .ResolveWith<Resolvers>(r => r.GetProducts(default!, default!))
               .UseDbContext<TrendyolAppDbContext>();
        }
        private class Resolvers
        {
            public IQueryable<Product> GetProducts(Cart cart, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Products.Where(p => p.Id == cart.ProductId);
            }
        }
    }


}
