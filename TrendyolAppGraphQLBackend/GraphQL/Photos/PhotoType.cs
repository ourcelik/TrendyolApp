using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.Photos
{
    public class PhotoType : ObjectType<Photo>
    {
        protected override void Configure(IObjectTypeDescriptor<Photo> descriptor)
        {
            descriptor.Description("Ürün fotorafları");
            descriptor
                .Field(p => p.Product)
                .ResolveWith<Resolvers>(r => r.GetProduct(default!, default!))
                .UseDbContext<TrendyolAppDbContext>()
                .Description("Fotoğrafın ait olduğu Product");
        }
        private class Resolvers
        {
            public Product GetProduct(Photo photo, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Products.FirstOrDefault(p => p.Id == photo.ProductId);
            }
        }
    }
}
