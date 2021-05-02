using Entities.Concrete.Entities;
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
        }
    }
}
