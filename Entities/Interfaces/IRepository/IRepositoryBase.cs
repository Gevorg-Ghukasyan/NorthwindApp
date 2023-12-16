using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepository
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        /// <summary>  
        /// Gets the specified identifier.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns>  
        TEntity Get(int id);

        /// <summary>  
        /// Gets the specified identifier async.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns>
        Task<TEntity> GetAsync(int id);

        /// <summary>  
        /// Gets all.  
        /// </summary>  
        /// <returns></returns>  
        IEnumerable<TEntity> GetAll();

        /// <summary>  
        /// Gets all async.  
        /// </summary>  
        /// <returns></returns>  
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>  
        /// First the or default.  
        /// </summary>  
        /// <returns></returns>  
        TEntity FirstOrDefault();

        /// <summary>  
        /// Singles the or default.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns>  
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        /// <summary>  
        /// Adds the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Add(TEntity entity);


        /// <summary>  
        /// Adds the specified entity async.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        Task AddAsync(TEntity entity);

        /// <summary>  
        /// Adds the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>  
        /// Adds the range async.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        Task AddRangeAsync(IEnumerable<TEntity> entities);

        /// <summary>  
        /// Removes the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Remove(TEntity entity);

        /// <summary>  
        /// Removes the specified entity async.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        Task RemoveAsync(TEntity entity);

        /// <summary>  
        /// Removes the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        void RemoveRange(IEnumerable<TEntity> entities);

        /// <summary>  
        /// Removes the range async.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);


        /// <summary>  
        /// Removes the TEntity by id.  
        /// </summary>  
        /// <param name="entityId">The entityId.</param>  
        void DeleteById(int entityId);

        /// <summary>  
        /// Removes the TEntity by id async.  
        /// </summary>  
        /// <param name="entityId">The entityId.</param>  
        Task DeleteByIdAsync(int entityId);
        /// <summary>
        /// Updates the specified entity.  
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);


        /// <summary>
        /// Updates the specified entity async.  
        /// </summary>
        /// <param name="entity"></param>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Updates the range.  
        /// </summary>
        /// <param name="entities"></param>
        void UpdateRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates the range async.  
        /// </summary>
        /// <param name="entities"></param>
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);

        /* /// <summary>  
         /// Finds the specified object.  
         /// </summary>  
         /// <param name="obj">The object.</param>  
         /// <returns></returns>  
         TEntity Find(object obj);

         /// <summary>  
         /// Finds the specified object.  
         /// </summary>  
         /// <param name="obj">The object Async.</param>  
         /// <returns></returns> 
         Task<TEntity> FindAsync(object obj);*/

        /// <summary>  
        /// Finds the specified predicate.  
        /// </summary>  
        /// <param name="predicate">The predicate .</param>  
        /// <returns></returns> 
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>  
        /// Finds the specified predicate.  
        /// </summary>  
        /// <param name="predicate">The predicate .</param>  
        /// <returns></returns> 
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Finds an entity by the specified key values.
        /// </summary>
        /// <param name="keyValues">The key values.</param>
        /// <returns>The found entity or null if not found.</returns>
        TEntity FindDefault(params object?[]? keyValues);


        /// <summary>
        /// Finds an entity by the specified key values asyn.
        /// </summary>
        /// <param name="keyValues">The key values.</param>
        /// <returns>A task representing the asynchronous operation. The result is the found entity or null if not found.</returns>
        Task<TEntity> FindDefaultAsync(params object?[]? keyValues);

        /// <summary>
        /// Calculates the sum of the specified numeric property for all entities.
        /// </summary>
        /// <param name="selector">Expression to select the numeric property.</param>
        /// <returns>The sum of the specified numeric property for all entities.</returns>
        int GetSum(Expression<Func<TEntity, int>> selector);

        /// <summary>
        /// Calculates the sum of the specified numeric property for all entities async.
        /// </summary>
        /// <param name="selector">Expression to select the numeric property.</param>
        /// <returns>A task representing the asynchronous operation. The result is the sum of the specified numeric property for all entities.</returns>
        Task<int> GetSumAsync(Expression<Func<TEntity, int>> selector);

    }
}
