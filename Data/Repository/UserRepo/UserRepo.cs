﻿using Data.Entities;
using Data.Repository.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.UserRepo
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        private readonly JewerlyV6Context _context;
        public UserRepo(JewerlyV6Context context) : base(context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Username == username);
        }

    }
}
