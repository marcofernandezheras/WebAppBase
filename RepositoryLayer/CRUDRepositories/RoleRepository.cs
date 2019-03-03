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
    
    public partial class RoleRepository
    {
    	protected DataModelContainer _context;
    
    	public RoleRepository(DataModelContainer context)
    	{
    		_context = context;
    	}
    
    	public virtual async Task<RoleData> Create(RoleData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            await _context.SaveChangesAsync();
    		return new RoleData(entity);
    	}
    
    	public virtual async Task<bool> Update(RoleData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            var rows = await _context.SaveChangesAsync();
            return rows > 0;
    	}
    
    	public virtual async Task<bool> Delete(RoleData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            var rows = await _context.SaveChangesAsync();
            return rows > 0;
    	}
    
    	public async Task<RoleData> Find(int id)
    	{
    		var entity = await _context.RoleSet.FindAsync(id);
    		return new RoleData(entity);
    	}
    
    	public async Task<PaginatedResult<RoleData>> Where(PaginatedRequest req, Func<Role, bool> predicate)
    	{
    		var count = await _context.RoleSet.CountAsync(u => predicate(u));
    		var list = await _context.RoleSet.Where(predicate)
                .Skip(req.CurrentPage * req.ItemPerPage)
                .Take(req.ItemPerPage)
    			.Select(i => new RoleData(i)).AsQueryable().ToListAsync();
    		return new PaginatedResult<RoleData>(req, totalItems: count, items: list);
    	}
    }
}