using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.SubCategories
{
    public class SubCategoryType : ObjectType<SubCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<SubCategory> descriptor)
        {
            descriptor
                .Field(p => p.Category)
                .ResolveWith<Resolvers>(r => r.GetCategory(default!, default!))
                .UseDbContext<TrendyolAppDbContext>();
        }

        private class Resolvers
        {

            public Category GetCategory(SubCategory subCategory, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Categories.SingleOrDefault(c => c.Id == subCategory.CategoryId);
            }

        }
    }
}
