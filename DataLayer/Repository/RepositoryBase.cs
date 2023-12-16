using Core.Abstraction;
using Core.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {

        #region Variables
        public readonly AppDataBaseContext _context;

        #endregion

        #region Constructor
        public RepositoryBase(AppDataBaseContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods
        /// <summary>  
        /// Adds the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        /// <summary>  
        /// Adds the specified entity async.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>  
        /// Adds the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        /// <summary>  
        /// Adds the range async.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        /// <summary>  
        /// Finds the specified predicate.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns>  
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);

        }

        /// <summary>  
        /// Finds the specified predicate async.  
        /// </summary>  
        /// <param name="predicate">The predicate .</param>  
        /// <returns></returns>  
        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Finds an entity by the specified key values.
        /// </summary>
        /// <param name="keyValues">The key values.</param>
        /// <returns>The found entity or null if not found.</returns>
        public TEntity FindDefault(params object?[]? keyValues)
        {
            return _context.Set<TEntity>().Find(keyValues);

        }

        /// <summary>
        /// Finds an entity by the specified key values asyn.
        /// </summary>
        /// <param name="keyValues">The key values.</param>
        /// <returns>A task representing the asynchronous operation. The result is the found entity or null if not found.</returns>
        public async Task<TEntity> FindDefaultAsync(params object?[]? keyValues)
        {
            return await _context.Set<TEntity>().FindAsync(keyValues);
        }

        /// <summary>  
        /// First the or default.  
        /// </summary>  
        /// <returns></returns>  
        public TEntity FirstOrDefault()
        {
            return _context.Set<TEntity>().FirstOrDefault();

        }

        /// <summary>  
        /// Gets the specified identifier.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns>  
        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);

        }

        /// <summary>  
        /// Gets the specified identifier async.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns> 
        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        /// <summary>  
        /// Gets all.  
        /// </summary>  
        /// <returns></returns>  
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();

        }

        /// <summary>  
        /// Gets all async.  
        /// </summary>  
        /// <returns></returns>  
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }


        /// <summary>  
        /// Removes the specified entity . 
        /// </summary>  
        /// <returns></returns>  
        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        /// <summary>  
        /// Removes the specified entity async. 
        /// </summary>  
        /// <returns></returns>  
        public async Task RemoveAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>  
        /// Removes the range.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        public  void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }

        /// <summary>  
        /// Removes the range async.  
        /// </summary>  
        /// <param name="entities">The entities.</param>  
        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        /// <summary>  
        /// Remove the TEntity by id .  
        /// </summary>  
        /// <param name="entityId">The entityId.</param>  
        public void DeleteById(int entityId)
        {
            var entity = _context.Set<TEntity>().Find(entityId);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
        }

        /// <summary>  
        /// Removes the TEntity by id async.  
        /// </summary>  
        /// <param name="entityId">The entityId.</param>  
        public async Task DeleteByIdAsync(int entityId)
        {
            var entity =  await _context.Set<TEntity>().FindAsync(entityId);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>  
        /// Singles the or default.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).SingleOrDefault();
        }

        /// <summary>
        /// Updates the specified entity.  
        /// </summary>
        /// <param name="entity"></param>
        public  void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates the specified entity async.   
        /// </summary>
        /// <param name="entity"></param>
        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();  
        }

        /// <summary>
        /// Updates the range.  
        /// </summary>
        /// <param name="entities"></param>
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates the range async.  
        /// </summary>
        /// <param name="entities"></param>
        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Calculates the sum of the specified numeric property for all entities .
        /// </summary>
        /// <param name="selector">Expression to select the numeric property.</param>
        /// <returns>A task representing the asynchronous operation. The result is the sum of the specified numeric property for all entities.</returns>
        public int GetSum(Expression<Func<TEntity, int>> selector)
        {
          return _context.Set<TEntity>().Sum(selector);
        }

        /// <summary>
        /// Calculates the sum of the specified numeric property for all entities async.
        /// </summary>
        /// <param name="selector">Expression to select the numeric property.</param>
        /// <returns>A task representing the asynchronous operation. The result is the sum of the specified numeric property for all entities.</returns>
        public async Task<int> GetSumAsync(Expression<Func<TEntity, int>> selector)
        {
            return await _context.Set<TEntity>().SumAsync(selector);
        }

        #endregion
    }
}
