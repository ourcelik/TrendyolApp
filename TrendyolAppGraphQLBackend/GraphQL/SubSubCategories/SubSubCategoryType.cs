using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL.SubSubCategories
{
    public class SubSubCategoryType : ObjectType<SubSubCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<SubSubCategory> descriptor)
        {
            base.Configure(descriptor);
            descriptor
               .Field(s => s.SubCategory)
               .ResolveWith<Resolvers>(r => r.GetSubCategory(default!, default!))
               .UseDbContext<TrendyolAppDbContext>();
            descriptor
               .Field(s => s.Category)
               .ResolveWith<Resolvers>(r => r.GetCategory(default!, default!))
               .UseDbContext<TrendyolAppDbContext>();
        }
        private class Resolvers
        {
            public Category GetCategory(SubSubCategory subSubCategory, [ScopedService] TrendyolAppDbContext context)
            {
                return context.Categories.SingleOrDefault(c => c.Id == subSubCategory.CategoryId);
            }

            public SubCategory GetSubCategory(SubSubCategory subSubCategory, [ScopedService] TrendyolAppDbContext context)
            {
                return context.SubCategories.SingleOrDefault(c => c.Id == subSubCategory.SubCategoryId);
            }


        }
    }
}
