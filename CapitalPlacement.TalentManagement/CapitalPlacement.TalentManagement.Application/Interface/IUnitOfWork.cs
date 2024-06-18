
namespace CapitalPlacement.TalentManagement.Application.Interface
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the repository for managing Programs.
        /// </summary>
        IProgramRepository Programs { get; }

        /// <summary>
        /// Saves changes synchronously.
        /// </summary>
        int Complete();

        /// <summary>
        /// Saves changes asynchronously.
        /// </summary>
        Task<int> CompleteAsync();
    }
}
