using DataAccess.Concrete;
using Entities.Concrete.Entities;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;

namespace TrendyolAppGraphQLBackend.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(TrendyolAppDbContext))]
        public IQueryable<Category> GetCategories([ScopedService] TrendyolAppDbContext context)
        {
            return context.Categories;
        }

    }
}
