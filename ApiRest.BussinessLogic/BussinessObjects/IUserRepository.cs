using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRest.Entities.Models;

namespace ApiRest.BussinessLogic.BussinessObjects
{
    public interface IUserRepository    
    {
        Task<List<User>> Get();
    }
}
