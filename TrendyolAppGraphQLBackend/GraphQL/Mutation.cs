using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TrendyolAppGraphQLBackend.GraphQL.Categories;

namespace TrendyolAppGraphQLBackend.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(TrendyolAppDbContext))]
        public async Task<AddCategoryPayload> AddCategoryAsync(AddCategoryInput input,
            [ScopedService] TrendyolAppDbContext context,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken)
        {
            var category = new Category
            {
                CategoryName = input.categoryName,
            };
            context.Categories.Add(category);
            await context.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnCategoryAdded), category, cancellationToken);

            return new AddCategoryPayload(category);
        }


    }
}
