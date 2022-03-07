using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetCategoriesAsync();
        Task<TEntity> GetByIdAsync(int? id);
        Task<TEntity> GetProductCategoryIdAsync(int? id);
        Task<TEntity> CreateAsync(TEntity category);
        Task<TEntity> UpdateAsync(TEntity category);
        Task<TEntity> RemoveAsync(TEntity category);
    }
}
