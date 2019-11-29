using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRest.DataAccess.DataObjects;
using ApiRest.Entities.Models;

namespace ApiRest.BussinessLogic.BussinessObjects
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserDataContext _context;
        public UserRepository(IUserDataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> Get()
        {
            return await Task.Factory.StartNew(() =>
            {
                return _context.Get();
            });
        }
    }
}
