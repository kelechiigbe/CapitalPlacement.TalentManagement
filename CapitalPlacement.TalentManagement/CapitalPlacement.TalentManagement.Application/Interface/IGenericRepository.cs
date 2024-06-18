
namespace CapitalPlacement.TalentManagement.Application.Interface
{
    /// <summary>
    /// Generic repository interface for CRUD operations.
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get entity by id.
        /// </summary>
        Task<T> GetAsync(Guid id);

        /// <summary>
        /// Get all entities.
        /// </summary>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Add a new entity.
        /// </summary>
        Task AddAsync(T entity);

        /// <summary>
        /// Delete an entity.
        /// </summary>
        void Delete(T entity);

        /// <summary>
        /// Update an entity.
        /// </summary>
        void Update(T entity);
    }

}
