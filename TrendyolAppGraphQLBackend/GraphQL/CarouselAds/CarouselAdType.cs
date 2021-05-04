using Entities.Concrete.Entities;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.CarouselAds
{
    public class CarouselAdType : ObjectType<CarouselAd>
    {
        protected override void Configure(IObjectTypeDescriptor<CarouselAd> descriptor)
        {
            descriptor.Description("CarouselAd reklamları");
        }
    }
}
