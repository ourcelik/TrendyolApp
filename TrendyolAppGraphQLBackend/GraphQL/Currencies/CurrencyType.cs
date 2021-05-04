using Entities.Concrete.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.Currencies
{
    public class CurrencyType : ObjectType<Currency>
    {
        protected override void Configure(IObjectTypeDescriptor<Currency> descriptor)
        {
            descriptor.Description("Para birimleri");
        }
    }
}
