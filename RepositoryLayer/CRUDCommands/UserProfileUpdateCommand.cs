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
    
    public partial class UserProfileUpdateCommand : IUpdateCommand<UserProfileData>
    {
    	protected DataModelContainer _context;
    
    	public UserProfileUpdateCommand(DataModelContainer context)
    	{
    		_context = context;
    	}
    	
    	public virtual async Task<CommandResult<UserProfileData>> Update(UserProfileData data)
    	{
            var entity = data.ToEntity();
            _context.Set(entity.GetType()).Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            var rows = await _context.SaveChangesAsync();
            return new CommandResult<UserProfileData>(data, new UserProfileData(entity), rows > 0);
    	}
    }
}
