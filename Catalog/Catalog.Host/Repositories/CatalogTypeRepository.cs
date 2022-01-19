using Catalog.Host.Data;
using Catalog.Host.Data.Entities;
using Catalog.Host.Repositories.Interfaces;

namespace Catalog.Host.Repositories
{
    public class CatalogTypeRepository : ICatalogTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CatalogTypeRepository(IDbContextWrapper<ApplicationDbContext> dbContext)
        {
            _dbContext = dbContext.DbContext;
        }

        public async Task<List<CatalogType>> GetAllAsync()
        {
            var itemsOnPage = await _dbContext.CatalogTypes
                .OrderBy(c => c.Type)
                .ToListAsync();

            return itemsOnPage;
        }
    }
}
