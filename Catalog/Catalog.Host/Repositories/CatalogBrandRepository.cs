using Catalog.Host.Data;
using Catalog.Host.Data.Entities;
using Catalog.Host.Repositories.Interfaces;

namespace Catalog.Host.Repositories
{
    public class CatalogBrandRepository : ICatalogBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CatalogBrandRepository(IDbContextWrapper<ApplicationDbContext> dbContext)
        {
            _dbContext = dbContext.DbContext;
        }

        public async Task<List<CatalogBrand>> GetAllAsync()
        {
            var itemsOnPage = await _dbContext.CatalogBrands
                .OrderBy(c => c.Brand)
                .ToListAsync();

            return itemsOnPage;
        }
    }
}
