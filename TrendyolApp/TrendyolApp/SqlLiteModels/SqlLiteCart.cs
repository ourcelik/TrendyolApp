using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.SqlLiteModels
{
    public class SqlLiteCart
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}
