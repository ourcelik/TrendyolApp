using Entities.Concrete.Entities;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyolAppGraphQLBackend.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Category OnCategoryAdded([EventMessage] Category category)
        {
            return category;
        }
    }
}
