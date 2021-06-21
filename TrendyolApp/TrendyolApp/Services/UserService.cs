using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using Firebase.Database.Query;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{

    class UserService : IUserService
    {
        readonly FirebaseClient _client;

        public UserService()
        {
            _client = new FirebaseClient("https://trendyolapp-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await _client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();
            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname,string passwd)
        {
            if (await IsUserExists(uname) ==false)
            {
                await _client.Child("Users")
                    .PostAsync(new User()
                    {
                        Username = uname,
                        Password = passwd,
                    }
                    );
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string uname,string passwd)
        {
            var user = (await _client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);
        }
    }
}
