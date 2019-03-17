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
namespace ServiceLayer.Services
{
    using DataLayer.Model;
    using DataLayer.Data;
    using RepositoryLayer;
    using RepositoryLayer.Interfaces;
    using System.Threading.Tasks;
    
    using DataLayer.Requests;
    using DataLayer.Results;
    using System.Linq;
    
    public partial class RoleService : IService<RoleData, Role>
    {
    	protected IQuery<RoleData, Role> _query;
    	protected ICreateCommand<RoleData> _createCommand;
    	protected IUpdateCommand<RoleData> _updateCommand;
    	protected IDeleteCommand<RoleData> _deleteCommand;
    
    	public RoleService(IQuery<RoleData, Role> query,
    		 ICreateCommand<RoleData> createCommand,
    		 IUpdateCommand<RoleData> updateCommand,
    		 IDeleteCommand<RoleData> deleteCommand)
    	{
    		_query = query;
    		_createCommand = createCommand;
    		_updateCommand = updateCommand;
    		_deleteCommand = deleteCommand;
    	}
    
    	public virtual async Task<CommandResult<RoleData>> Create(RoleData data)
    	{
    		try
            {
                return await _createCommand.Create(data);
            } 
    		catch (Exception ex)
            {
    			//TODO Trace ex
    			return new CommandResult<RoleData>(data, ex);
    		}
    	}
    
    	public virtual async Task<CommandResult<RoleData>> Update(RoleData data)
    	{
    		try
            {
                return await _updateCommand.Update(data);
            } 
    		catch (Exception ex)
            {
    			//TODO Trace ex
    			return new CommandResult<RoleData>(data, ex);
    		}
    	}
    
    	public virtual async Task<CommandResult<RoleData>> Delete(RoleData data)
    	{
    		try
            {
                return await _deleteCommand.Delete(data);
            } 
    		catch (Exception ex)
            {
    			//TODO Trace ex
    			return new CommandResult<RoleData>(data, ex);
    		}
    	}
    
    	public async Task<FindResult<RoleData>> Find(params object[] keyValues)
    	{
    		try
            {
                return await _query.Find(keyValues);
            } 
    		catch (Exception ex)
            {
     			//TODO Trace ex
    			return new FindResult<RoleData>(ex);
    		}
    	}
    
    	public async Task<WhereResult<RoleData>> Where(PaginatedRequest req, Func<Role, bool> predicate)
    	{
    		try
            {
                return await _query.Where(req, predicate);
            }
    		catch (Exception ex)
            {
     			//TODO Trace ex
    			return new WhereResult<RoleData>(ex);
    		}
    	}
    }
}
