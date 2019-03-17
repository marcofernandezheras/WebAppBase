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
    
    public partial class UserProfileQuery : IQuery<UserProfileData, UserProfile>
    {
    	protected DataModelContainer _context;
    
    	public UserProfileQuery(DataModelContainer context)
    	{
    		_context = context;
    	}
    
    	public virtual async Task<FindResult<UserProfileData>> Find(params object[] keyValues)
    	{
    		var entity = await _context.UserProfileSet.FindAsync(keyValues);
    		return new FindResult<UserProfileData>(new UserProfileData(entity));
    	}
    
    	public virtual async Task<WhereResult<UserProfileData>> Where(PaginatedRequest req, Func<UserProfile, bool> predicate)
    	{
    		var count = await _context.UserProfileSet.CountAsync(u => predicate(u));
    		var list = await _context.UserProfileSet.Where(predicate)
                .Skip(req.CurrentPage * req.ItemPerPage)
                .Take(req.ItemPerPage)
    			.Select(i => new UserProfileData(i)).AsQueryable().ToListAsync();
    		return new WhereResult<UserProfileData>( new PaginatedResult<UserProfileData>(req, totalItems: count, items: list));
    	}
    }
}