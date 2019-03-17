//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
namespace RepositoryLayer.Repositories
{
    using DataLayer.Model;
    using DataLayer.Data;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using DataLayer.Requests;
    using DataLayer.Results;
    using System.Linq;
    using RepositoryLayer.Interfaces;
    
    public partial class RoleQuery : IQuery<RoleData, Role>
    {
    	protected DataModelContainer _context;
    
    	public RoleQuery(DataModelContainer context)
    	{
    		_context = context;
    	}
    
    	public virtual async Task<FindResult<RoleData>> Find(params object[] keyValues)
    	{
    		var entity = await _context.RoleSet.FindAsync(keyValues);
    		return new FindResult<RoleData>(new RoleData(entity));
    	}
    
    	public virtual async Task<WhereResult<RoleData>> Where(PaginatedRequest req, Func<Role, bool> predicate)
    	{
    		var count = await _context.RoleSet.CountAsync(u => predicate(u));
    		var list = await _context.RoleSet.Where(predicate)
                .Skip(req.CurrentPage * req.ItemPerPage)
                .Take(req.ItemPerPage)
    			.Select(i => new RoleData(i)).AsQueryable().ToListAsync();
    		return new WhereResult<RoleData>( new PaginatedResult<RoleData>(req, totalItems: count, items: list));
    	}
    }
}