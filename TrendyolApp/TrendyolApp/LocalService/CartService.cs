using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.SqlLiteModels;
using Xamarin.Essentials;

namespace TrendyolApp.LocalService
{

    static class CartService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<SqlLiteCart>();
        }
        public static async Task Add(SqlLiteCart cart)
        {
            await Init();
            var data = await GetByProductId(cart.ProductId);
            if (data != null)
            {
                data.Count += 1;
                await db.UpdateAsync(data);
            }
            else
            {
                await db.InsertAsync(cart);
            }

        }

        public static async Task Delete(int id)
        {
            await Init();
            var data = await Get(id);
            if (data.Count > 1)
            {
                data.Count -= 1;
                await db.UpdateAsync(data);
            }
            else
            {
                await db.DeleteAsync<SqlLiteCart>(id);
            }
        }

        public static async Task<List<SqlLiteCart>> GetAll()
        {
            await Init();

            var carts = await db.Table<SqlLiteCart>().ToListAsync();
            return carts;
        }
        public static async Task<SqlLiteCart> Get(int id)
        {
            await Init();
            var cart = await db.Table<SqlLiteCart>()
                .FirstOrDefaultAsync(c => c.Id == id);
            return cart;

        }
        public static async Task<SqlLiteCart> GetByProductId(int id)
        {
            await Init();
            var cart = await db.Table<SqlLiteCart>()
                .FirstOrDefaultAsync(c => c.ProductId == id);
            return cart;

        }

        public static async Task Update(SqlLiteCart cart)
        {
            await Init();

            await db.UpdateAsync(cart);

        }
        public static async Task DeleteAllCartData()
        {
            await db.DeleteAllAsync<SqlLiteCart>();
        }
    }
}
