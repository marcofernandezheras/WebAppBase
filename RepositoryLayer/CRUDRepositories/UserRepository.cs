//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryLayer.Repositories
{
    using DataLayer.Model;
    using DataLayer.Data;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using DataLayer.Requests;
    using DataLayer.Results;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    
    public partial class UserRepository
    {
    	protected DataModelContainer _context;
    
    	public UserRepository(DataModelContainer context)
    	{
    		_context = context;
    	}
    
    	public virtual async Task<UserData> Create(UserData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            await _context.SaveChangesAsync();
    		return new UserData(entity);
    	}
    
    	public virtual async Task<bool> Update(UserData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            var rows = await _context.SaveChangesAsync();
            return rows > 0;
    	}
    
    	public virtual async Task<bool> Delete(UserData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            var rows = await _context.SaveChangesAsync();
            return rows > 0;
    	}
    
    	public async Task<UserData> Find(System.Guid id)
    	{
    		var entity = await _context.UserSet.FindAsync(id);
    		return new UserData(entity);
    	}
    
    	public async Task<PaginatedResult<UserData>> Where(PaginatedRequest req, Func<User, bool> predicate)
    	{
    		var count = await _context.UserSet.CountAsync(u => predicate(u));
    		var list = await _context.UserSet.Where(predicate)
                .Skip(req.CurrentPage * req.ItemPerPage)
                .Take(req.ItemPerPage)
    			.Select(i => new UserData(i)).AsQueryable().ToListAsync();
    		return new PaginatedResult<UserData>(req, totalItems: count, items: list);
    	}
    }
}
