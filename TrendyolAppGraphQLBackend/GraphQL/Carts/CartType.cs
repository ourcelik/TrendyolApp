using Entities.Concrete.Entities;
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
        }
    }
}
