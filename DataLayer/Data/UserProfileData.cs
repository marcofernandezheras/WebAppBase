//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using DataLayer.Model;
using System.Linq;

using System;
using System.Collections.Generic;
namespace DataLayer.Data
{
    
    public partial class UserProfileData
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string LastSurname { get; set; }
    
        public virtual UserData User { get; set; }
    
    	public UserProfileData() 
    	{
    	}
    
    	public UserProfileData(UserProfile source, bool deepCopy = true)
    	{
    		this.Id = source.Id;
    		this.IdUser = source.IdUser;
    		this.Name = source.Name;
    		this.FirstSurname = source.FirstSurname;
    		this.LastSurname = source.LastSurname;
    		if(deepCopy)
    		{
    			if(source.User != null)
    			{
    				this.User = new UserData(source.User, deepCopy: false);
    			}
    		}
    	} 
    	
    	public UserProfile ToEntity()
    	{
    		var entity = new UserProfile();
    		entity.Id = this.Id;
    		entity.IdUser = this.IdUser;
    		entity.Name = this.Name;
    		entity.FirstSurname = this.FirstSurname;
    		entity.LastSurname = this.LastSurname;
    		return entity;
    	}
    }
}
