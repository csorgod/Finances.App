using Finances.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Finances.App.Services
{
    class FavoredService : BaseService
    {
        public FavoredService() { }

        public async Task<IEnumerable<Favored>> GetFavoredByUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
